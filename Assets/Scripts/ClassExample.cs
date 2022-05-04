using UnityEngine;

namespace ClassExample
{
    public class ExampleClass
    {
        public void createEnemies()
        {
            var enemy1 = new Enemy(100, "toinen vihu");
            enemy1.SetHP(4);

            Enemy.DescribeEnemies();
            Debug.Log(Enemy.enemyDescription);
        }
    }

    public class Enemy
    {
        protected int HP = 0;
        protected int maxHP = 0;
        protected string name; 
        public static string enemyDescription = "Enemies are bouncy";

        public Enemy(int newMaxHP, string newName)
        {
            maxHP = newMaxHP;
            HP = maxHP;
            name = newName;
            Debug.Log($"Enemy {newName} created with HP {HP}!");
        }
        public Enemy()
        {
            maxHP = 10;
            HP = maxHP;
            name = "DefaulttiNimi";
            Debug.Log($"Enemy {name} created with HP {HP}!");
        }
        public virtual void SetHP(int newHP)
        {
            Debug.Log(enemyDescription);
            this.HP = newHP;
        }
        public static void DescribeEnemies()
        {
            Debug.Log("Enemies are spiky");
        }
    }

    public class Grunt : Enemy
    {
        public Grunt(int index)
        {
            name = "Grunt " + index;
            maxHP = 5;
            HP = maxHP;
        }
        public void SetHP(int newHP)
        {
            this.HP = newHP + 1;
        }
        public static new void DescribeEnemies()
        {
            Debug.Log("Grunts are silly");
        }
    }
}