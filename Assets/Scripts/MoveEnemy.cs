using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    float constantSpeed = 2;
    void Update()
    {
        Vector3 velocity = new Vector3(constantSpeed * Time.deltaTime, 0.0f, 0.0f);
        transform.position += velocity;
    }
}
