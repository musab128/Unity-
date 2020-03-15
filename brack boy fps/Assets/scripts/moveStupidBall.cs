
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class moveStupidBall : MonoBehaviour
{
    Rigidbody rb;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }
    public void Move(Vector3 v3)
    {
        velocity = v3;
    }

    private void FixedUpdate()
    {
        MoveMyGuy();
    }

    void MoveMyGuy()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.deltaTime );
        }
    }
}
