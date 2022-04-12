using UnityEngine;

public class GameObjectScripting : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Kissat koiria"), Range(-20,20), SerializeField]
    float constantSpeed = 2;
    [SerializeField] GameObject kaveri;
    [SerializeField] GameObject ekaLapsi;
    [SerializeField] GameObject tokaLapsi;
    [SerializeField] GameObject äitee;


    void Awake()
    {
        Debug.Log("Awake!");    
    }
    void Start()
    {
        Debug.Log("Start!");
        kaveri = GameObject.Find("Kaveri");
        
        ekaLapsi = transform.GetChild(0).gameObject;
        tokaLapsi = transform.Find("Minion").gameObject;

        äitee = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (ekaLapsi != null && tokaLapsi != null)
        {
            Debug.Log(äitee.name);
            Debug.Log($"ekalapsi: {ekaLapsi.name}, tokalapsi: {tokaLapsi.name}");
        }

        Vector3 velocity = new Vector3(constantSpeed * Time.deltaTime, 0.0f, 0.0f);
        if (kaveri != null)
            kaveri.transform.position += velocity;
        transform.position += velocity;
    }
}
