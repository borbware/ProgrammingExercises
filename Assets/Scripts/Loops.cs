using UnityEngine;

public class Loops : MonoBehaviour
{
    int numberOfEnemies = 2000;
    [SerializeField] GameObject solttu;
    [SerializeField] GameObject lähetti;
    void WhileLoop()
    {
        int count = 5;
        while(count < numberOfEnemies )
        {
            Debug.Log(count);
            count ++;
        }
    }

    void DoWhileLoop()
    {
        int count = 5;
        do {
            Debug.Log(count);
            count ++;
        } while(count < 4);
    }

    void CreateSolttu(int x, int z)
    {
        Debug.Log("Current: " + x);
        Vector3 solttuPosition = 
            transform.position
            + Vector3.right * x * 2
            + Vector3.forward * z * 2;
        if (lähetti.transform.position == solttuPosition)
            return; // can't use continue in a separate function
        Instantiate(
            solttu,
            solttuPosition,
            transform.rotation
        );
    }

    void CreateFieldOfSolttus()
    {
        for (int z = 0; z <= 7; z++ )
            for (int x = 0; x <= 7; x++)
                CreateSolttu(x, z);
    }

    private void Start() {
        CreateFieldOfSolttus();
    }

    private void Update() {
        
    }
}