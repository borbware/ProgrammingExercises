using UnityEngine;

public class Functions : MonoBehaviour
{

    void PrintNames(string name1, string name2)
    {
        Debug.Log($"name1: {name1}, name2: {name2}");
    }
    string CreateBand(string name1, string name2)
    {
        string bandName = $"{name1} ja {name2} -orkesteri";
        return bandName;
    }
    // Start is called before the first frame update
    void Start()
    {
        string bandName = CreateBand("Matti", "Teppo");
        Debug.Log(bandName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
