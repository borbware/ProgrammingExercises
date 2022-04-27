using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        var compo = other.gameObject.GetComponent<SolttuKoodi>();
        if (compo != null)
        {
            compo.Heal(43);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
