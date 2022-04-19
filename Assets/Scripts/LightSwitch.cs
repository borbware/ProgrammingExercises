using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] GameObject redLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            Destroy(redLight);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
