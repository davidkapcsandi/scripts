using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float speed = 5;
    public float xSensitivity = 10f;
    public float ySensitivity = 10f;
    public int inverty = -1;

    private Rigidbody rBody;
    private Vector3 moveInput;
    private Vector3 rotationInput;
    public Transform camtransform;


    private float pitch;
    private float yaw;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");
        rotationInput.y = Input.GetAxis("Mouse X");
        rotationInput.x = Input.GetAxis("Mouse Y") * inverty;

        yaw += rotationInput.y * xSensitivity * Time.deltaTime;
        pitch += rotationInput.x * ySensitivity * Time.deltaTime;

        rBody.rotation = Quaternion.Euler(0, yaw, 0);
        camtransform.localRotation = Quaternion.Euler(pitch, 0, 0);

        Vector3 finalDir = transform.forward * moveInput.z;
        finalDir += transform.right * moveInput.x;


        rBody.AddForce(finalDir * speed);
    }

}
