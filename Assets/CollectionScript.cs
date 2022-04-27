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
            Debug.Log(EnemyHPArray[i]);
        }        
    }

    void Start()
    {
        EnemyHPList = new List<int> {21, 34, 21, 3};
        var temppilista = new List<int>();

        EnemyHPList[0] = 2;
        EnemyHPList.Add(29);
        EnemyHPList.Remove(21);
        EnemyHPList.RemoveAt(2);

        for (int i = 0; i < EnemyHPList.Count; i++)
        {
            Debug.Log(EnemyHPList[i]);
        }



        // ArrayStuff();
    }

    void Update()
    {
        
    }
}
