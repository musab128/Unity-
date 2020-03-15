using UnityEngine;

public class MoveFace : MonoBehaviour
{
    public float TurnSpeed;
    public Transform playerTrans;
    float XRotation;
    private void Start(){
        Cursor.lockState = CursorLockMode.Locked; 
    }

    private void Update()
    {
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * TurnSpeed;
        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * TurnSpeed;

        XRotation -= y;
        XRotation = Mathf.Clamp(XRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        playerTrans.Rotate(Vector3.up * x);
    }
}
