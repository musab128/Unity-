using UnityEngine;

public class majd : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
            rb.AddForce(10, 0, 0);

        if (Input.GetKey("s"))
            rb.AddForce(-10, 0, 0);

        if (Input.GetKey("a"))
            rb.AddForce(0, 0, 10);

        if (Input.GetKey("d"))
            rb.AddForce(10, 0, -10);
    }
}
