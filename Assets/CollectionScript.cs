using UnityEngine;
using System.Collections.Generic;

public class CollectionScript : MonoBehaviour
{
    [SerializeField]
    int[] EnemyHPArray = {2, 8, 10, 15, 9, 6, 213, 555}; // array
    [SerializeField]
    List<int> EnemyHPList; // list

    void ArrayStuff()
    {
        EnemyHPArray[0] = 10;
        for (int i = 0; i < EnemyHPArray.Length; i++)
        {
            EnemyHPArray[i] += 5;
            // Debug.Log(EnemyHPArray[i]);
        }

        foreach (var HP in EnemyHPArray)
        {
            // HP += 4;
        }
        GameObject[] soltut = GameObject.FindGameObjectsWithTag("Solttu");
        foreach (var solttu in soltut)
        {
            solttu.transform.position += Vector3.forward * 1;
        }
    }

    void Start()
    {
        EnemyHPList = new List<int> {4, 5, 34, 21, 3};
        var temppilista = new List<int>();

        // EnemyHPList[0] = 2;
        // EnemyHPList.Add(29);
        // EnemyHPList.Remove(21);
        // EnemyHPList.RemoveAt(2);

        if (EnemyHPList.Contains(34))
        {
            Debug.Log("siellähän se 34 on");
        }
        foreach (var HP in EnemyHPList)
        {
            // Debug.Log(HP);
        }

        // if you remove stuff, loop in reverse order
        for (int i = EnemyHPList.Count - 1; i >= 0; i--)
        {
            Debug.Log(EnemyHPList.Count);
            if (EnemyHPList[i] < 10)
                EnemyHPList.RemoveAt(i);
        }

        ArrayStuff();
    }
    bool shoot;
    void Update()
    {
        shoot = Input.GetButtonDown("Fire1");
        transform.Rotate(new Vector3(0, 0, 90));
    }
    void FixedUpdate() {
        if (shoot)
        {
            
        }
    }
}
