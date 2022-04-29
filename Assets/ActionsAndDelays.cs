using System.Collections;
using UnityEngine;

public class ActionsAndDelays : MonoBehaviour
{
    float period = 0.5f;
    float nextActionTime = 0.5f; 
    GameObject lähetti;
    Renderer lähettiRenderer;
    SetColor lähettiSetColor;
    void Actions ()
    {
        
        // lähettiSetColorClass.SetColorToRed();
        lähetti.SendMessage(
            "SetColorTo",
            new Color(0.1f,0.7f,0.6f)
        );
    }

    void SetLähettiColorToRandom()
    {
        var _renderer = lähetti.GetComponent<Renderer>();
        _renderer.material.SetColor("_Color", new Color(
            Random.Range(0f,1f),
            Random.Range(0f,1f),
            Random.Range(0f,1f)
        ));
    }
    void Invokes()
    {

        // Invoke("SetLähettiColorToRandom", 1.0f);
        // lähettiSetColorClass.Invoke("SetColorToRandom", 1.0f);
        // lähettiSetColorClass.InvokeRepeating("SetColorToRandom", 1.0f, 0.5f);

        InvokeRepeating(
            "SendMessageToLähettiSoItChangesItsColorToRandom",
            1.0f,
            0.5f
        );
        Invoke(
            "CancelInvokeSendMessageToLähettiSoItChangesItsColorToRandom",
            5.0f
        );

        // InvokeUntil(
        //     "SendMessageToLähettiSoItChangesItsColorToRandom",
        //     1.0f, 0.5f, 5.0f
        // );
    }
    void SendMessageToLähettiSoItChangesItsColorToRandom()
    {
        lähetti.SendMessage("SetColorToRandom");
    }
    void CancelInvokeSendMessageToLähettiSoItChangesItsColorToRandom()
    {
        CancelInvoke("SendMessageToLähettiSoItChangesItsColorToRandom");
    }

    void DoEveryXSeconds()
    {
        if (Time.time > nextActionTime)
        {
            lähetti.SendMessage("SetColorToRandom");
            nextActionTime = Time.time + period;
        }
    }
    void InvokeUntil(string functionName, float startTime, float period, float endTime)
    {
        // UNDER CONSTRUCTION
        InvokeRepeating(functionName, startTime, period);
        Invoke("CancelInvoke" + functionName, endTime);
    }
    float DistanceToLähetti()
    {
        Vector3 distanceVector = transform.position - lähetti.transform.position;
        float distance = distanceVector.magnitude;
        return distance;
    }

    IEnumerator Fade()
    {
        Color c = lähettiRenderer.material.color;
        for (float red = 1f; red >= 0; red -= 0.1f)
        {
            c.r = red;
            Debug.Log(red);
            lähettiRenderer.material.color = c;
            // yield return null;
            yield return new WaitForSeconds(.1f);
        }
    }

    IEnumerator ChangeColorToRandom()
    {
        yield return new WaitForSeconds(0.1f);

        lähetti.SendMessage("SetColorToRandom");
        Debug.Log("eka");
        yield return new WaitForSeconds(2f);
        
        lähetti.SendMessage("SetColorToRandom");
        Debug.Log("toka");
        yield return new WaitForSeconds(2f);
        
        lähetti.SendMessage("SetColorToRandom");
        Debug.Log("kolmas");
        yield return new WaitForSeconds(2f);
    }
    IEnumerator fade;
    void Start()
    {
        lähetti = GameObject.Find("Lähetti");
        lähettiSetColor = lähetti.GetComponent<SetColor>();
        lähettiRenderer = lähetti.GetComponent<Renderer>();

        // Actions();
        // Invokes();
        // Fade();
        // StartCoroutine(Fade());
        fade = Fade();
    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // StartCoroutine(ChangeColorToRandom());
            StartCoroutine(fade);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            StopCoroutine(fade);
        }



        
        if (DistanceToLähetti() < 3)
        {
            // do stuff
        }
        // DoEveryXSeconds();
        // if (Time.time > 5.0f)
        // {
        //     CancelInvoke("SendMessageToLähettiSoItChangesItsColorToRandom");
        // }
    }
}
