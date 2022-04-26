using UnityEngine;

public class LookAt : MonoBehaviour
{
    GameObject target;
    void Start()
    {
        target = GameObject.Find("Kuutio");
    }
    void Update()
    {
        transform.LookAt(target.transform);
    }
}
