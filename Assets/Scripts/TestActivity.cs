using UnityEngine;

public class TestActivity : MonoBehaviour
{
    GameObject enemy;
    GameObject goon;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy");
        goon = enemy.transform.Find("Goon").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (goon.activeSelf)
            Debug.Log("goon activeself");
        if (goon.activeInHierarchy)
            Debug.Log("goon active in hierarchy");
        
    }
}
