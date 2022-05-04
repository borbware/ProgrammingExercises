using UnityEngine;

public class ClassExample
{
    public void createEnemies()
    {
        var enemy1 = new Enemy();
        enemy1.SetHP(4);

        Enemy.DescribeEnemies();
        Debug.Log(Enemy.enemyDescription);
    }
}

public class Enemy
{
    private int HP = 0;
    public static string enemyDescription = "Enemies are bouncy";
    public void SetHP(int newHP)
    {
        Debug.Log(enemyDescription);
        this.HP = newHP;
    }
    public static void DescribeEnemies()
    {
        Debug.Log("Enemies are spiky");
        Debug.Log(enemyDescription);
    }
}