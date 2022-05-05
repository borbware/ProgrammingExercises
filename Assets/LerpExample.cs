using UnityEngine;

public class LerpExample : MonoBehaviour
{

    float a = -5f;
    float b = 2f;
    float t = 0f;

    Renderer _renderer;
    bool lerping = false;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!lerping && Input.GetButtonDown("Jump"))
        {
            lerping = true;
            t = 0;
            a = transform.position.x;
            b = transform.position.x + 5;
        }

        if (lerping)
        {
            transform.position = new Vector3(
                Mathf.Lerp(a, b, t),
                transform.position.y,
                transform.position.z);

            // _renderer.material.SetColor("_Color", 
            //     new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, t))
            // );
            
            t += Time.deltaTime * 0.5f;

            if (transform.position.x == b)
                lerping = false;
        }


    }
}
