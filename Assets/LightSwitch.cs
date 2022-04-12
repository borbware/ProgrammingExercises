using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("heh"); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
