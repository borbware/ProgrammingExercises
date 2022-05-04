using UnityEngine;

public class ClassScripting : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Enemy.enemyDescription);
        var enemy1 = new Enemy();
        var classExample = new ClassExample();
        classExample.createEnemies();
    }
}
