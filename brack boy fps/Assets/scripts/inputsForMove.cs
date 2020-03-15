using UnityEngine;
[RequireComponent(typeof(moveStupidBall))]

public class inputsForMove : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    moveStupidBall motor;

    private void Start()
    {
        motor = GetComponent<moveStupidBall>();
    }

     void Update()
    {
        float Verti = Input.GetAxisRaw("Vertical");
        float horiz = Input.GetAxisRaw("Horizontal");

        Vector3 v3 = (transform.right * horiz + transform.forward * Verti).normalized * speed;
       

        
        motor.Move(v3);

    }
}
