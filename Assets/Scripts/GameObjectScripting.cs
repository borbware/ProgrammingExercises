using UnityEngine;

public class GameObjectScripting : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Kissat koiria"), Range(-20,20), SerializeField]
    float constantSpeed = 2;
    [SerializeField] GameObject kaveri;
    [SerializeField] GameObject ekaLapsi;
    [SerializeField] GameObject tokaLapsi;
    [SerializeField] GameObject kolmasLapsi;
    [SerializeField] GameObject äitee;

    bool isDestroyed = false;
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
        kolmasLapsi = Instantiate(
            tokaLapsi,                      // create copy of tokaLapsi
            new Vector3(0.5f, 0.0f, -1.0f), // position with respect to parent
            Quaternion.identity,            // default rotation 
            transform                       // parent is this gameobject's transform
        );
        
        kolmasLapsi.name = "Grunt";

        äitee = transform.parent.gameObject;

        transform.SetParent(kaveri.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (ekaLapsi != null && tokaLapsi != null)
        {
            Debug.Log(äitee.name);
            Debug.Log(transform.parent.name);
            Debug.Log($"ekalapsi: {ekaLapsi.name}, tokalapsi: {tokaLapsi.name}");
        }

        Vector3 velocity = new Vector3(constantSpeed * Time.deltaTime, 0.0f, 0.0f);
        if (kaveri != null)
            kaveri.transform.position += velocity;
        transform.position += velocity;

        if (Time.time > 3.0f && !isDestroyed)
        {
            Destroy(kaveri);
            isDestroyed = true;
        }

    }
}
