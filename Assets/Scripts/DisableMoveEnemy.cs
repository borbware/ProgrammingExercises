using UnityEngine;

public class DisableMoveEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    MonoBehaviour moveEnemy;
    void Start()
    {
        enemy = GameObject.Find("Enemy");
        moveEnemy = enemy.GetComponent<MoveEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveEnemy.enabled = !moveEnemy.enabled;
        }
    }
}
