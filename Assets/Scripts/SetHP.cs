using UnityEngine;

public class SetHP : MonoBehaviour
{

    [SerializeField] string EntityType;
    [SerializeField] int HP;
    [SerializeField] int maxHP = 5;
    public bool isRed;
    public void SetNewHP(int newHP)
    {
        isRed = false;
        HP = newHP;
        Debug.Log($"I'm {EntityType} and my HP is {HP}!");
    }
    void Start()
    {
        SetNewHP(maxHP);

        // if (EntityType == "Player")
        //     SetNewHP(50);
        // else if (EntityType == "Enemy")
        //     SetNewHP(10);
    }
}
