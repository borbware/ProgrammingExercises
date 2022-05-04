using UnityEngine;
using ClassExample;

public class ClassScripting : MonoBehaviour
{
    void BasicExamples()
    {
        Debug.Log(Enemy.enemyDescription);
        var enemy1 = new Enemy(10, "Vihu");
        var enemy2 = new Enemy();
        var classExample = new ExampleClass();
        classExample.createEnemies();
    }
    void Start()
    {
        // BasicExamples();

        var grunt1 = new Grunt(1);
        var grunt2 = new Grunt(2);
        var grunt3 = new Grunt(3);
        Enemy.DescribeEnemies();
        Grunt.DescribeEnemies();

        grunt1.SetHP(2);

    }
}
