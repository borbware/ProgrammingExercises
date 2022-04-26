using UnityEngine;

public class TransformExamples : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject myChild;
    void Start()
    {
        myChild = transform.Find("Lapsonen").gameObject;
        Debug.Log(myChild.name);
    }

    void Translate()
    {
		if (Input.GetKey(KeyCode.UpArrow))
            // myChild.transform.Translate(
            //     new Vector3(0,0,2f * Time.deltaTime));
            // myChild.transform.localPosition +=
            //    new Vector3(0, 0, 2f * Time.deltaTime);
            myChild.transform.position += 
                new Vector3(0, 0, 2f * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
            myChild.transform.Translate(
                new Vector3(0, 0, -2f * Time.deltaTime));
    }
    void Rotate()
    {
        // Vector3.up = new Vector3(0,1,0) 
        if (Input.GetKey(KeyCode.Space))
            transform.RotateAround(
                myChild.transform.position,
                myChild.transform.up,
                360 * Time.deltaTime
            );
        if (Input.GetKey(KeyCode.LeftAlt))
            transform.RotateAround(
                transform.position,
                transform.right,
                180 * Time.deltaTime
            );
            // More difficult way:
            // transform.Rotate(
            //     0,
            //     180 * Time.deltaTime,
            //     0,
            //     Space.Self
            // );
    }
    void Scale()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Translate();
        Rotate();
    }
}
