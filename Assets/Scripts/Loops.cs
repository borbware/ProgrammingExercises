using UnityEngine;

public class Loops : MonoBehaviour
{
    int numberOfEnemies = 2000;
    [SerializeField] GameObject[] solttus = new GameObject[64];
    GameObject[,] solttus2D = new GameObject[8,8];
    int numberOfSolttus = 0;
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

    void CreateSolttu(int x, int y, int z)
    {
        // Debug.Log("Current: " + x);
        Vector3 solttuPosition = 
            transform.position
            + Vector3.right * x * 2
            + Vector3.up * y * 2
            + Vector3.forward * z * 2;
        if (Vector3.ProjectOnPlane(
                lähetti.transform.position, Vector3.up)
            == Vector3.ProjectOnPlane(
                    solttuPosition, Vector3.up)
            )
            return; // can't use continue in a separate function
        GameObject newSolttu = Instantiate(
            solttu,
            solttuPosition,
            transform.rotation
        );
        solttus2D[x, z] = newSolttu;

        solttus[numberOfSolttus] = newSolttu;
        numberOfSolttus++;
    }

    void CreateFieldOfSolttus()
    {
        for (int z = 0; z <= 7; z++ )
            // for (int y = 0; y <= 7; y++)
                for (int x = 0; x <= 7; x++)
                    CreateSolttu(x, 0, z);
    }

    private void RotateSolttus()
    {
        for (int i = 0; i < solttus.Length; i++)
        {
            Debug.Log(i);
            solttus[i].transform.RotateAround(
                solttus[i].transform.position,
                Vector3.up,
                15 * i
            );
        }        
    }

    private void RotateSolttus2D()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                var solttu = solttus2D[x,y];
                if (solttu != null)
                {
                    Debug.Log(x + " " + y);
                    solttu.transform.RotateAround(
                        solttu.transform.position,
                        Vector3.up,
                        5 * x + 5 * y
                    );
                }
            }        
        }
    }

    private void Start() {
        CreateFieldOfSolttus();
        // RotateSolttus();
        RotateSolttus2D();
    }

    private void Update() {
        
    }
}