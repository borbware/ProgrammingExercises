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
    void AdvancedExamples()
    {
        var grunt1 = new Grunt(1);
        var grunt2 = new Grunt(2);
        var grunt3 = new Grunt(3);
        Enemy.DescribeEnemies();
        Grunt.DescribeEnemies();

        grunt1.SetHP(2);
    }
    void ValueVsReferenceExample()
    {
        int firstValueType = 15;
        Debug.Log(firstValueType);
        int secondValueType = firstValueType;
        secondValueType++;
        Debug.Log(
            $"firstValueType: {firstValueType}, secondValueType: {secondValueType}");

        var firstReferenceType = new Enemy(15, "FirstEnemy");
        Debug.Log(firstReferenceType.GetHP());
        var secondReferenceType = firstReferenceType;
        secondReferenceType.SetHP(16);
        Debug.Log(
            $"firstReferenceType.HP: {firstReferenceType.GetHP()}, secondReferenceType.HP: {secondReferenceType.GetHP()}");


    }
    void GetterSetterExample()
    {
        var enemy1 = new Enemy(10, "Ketteri");
        enemy1.HitPoint = 20;
        Debug.Log(enemy1.HitPoint);
    }
    void Start()
    {
        // BasicExamples();
        // AdvancedExamples();
        // ValueVsReferenceExample();
        GetterSetterExample();
    }
}
