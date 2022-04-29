using UnityEngine;

public class Kaveri : MonoBehaviour
{
    // Start is called before the first frame update
    bool pressedSwordButton;
    Vector2 playerInput;
    void Start()
    {
        Debug.Log("dsaf");
    }

    void FixedUpdate()
    {
        if (pressedSwordButton)
        {
            
        }
        if (playerInput.x > 0)
        {

        }
    }

    void Update()
    {
        pressedSwordButton = Input.GetButtonDown("Fire1");
        playerInput = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }
    bool IsPlayerOrPatrol(GameObject who)
    {
        return (
            who.gameObject.CompareTag("Player")
            || who.gameObject.CompareTag("Patrol")); 
    }
    private void OnTriggerEnter(Collider other) {
        if (IsPlayerOrPatrol(other.gameObject) 
        && IsPlayerOrPatrol(this.gameObject))
        {

        }
    }
}
