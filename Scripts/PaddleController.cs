using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public int speed = 30;
    float roll = 0;
    float pitch = 0;
    float turn = 0;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            roll += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            roll -= speed * Time.deltaTime;  
        }
        if (Input.GetKey(KeyCode.D))
        {
            pitch += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pitch-= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            turn += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            turn -= speed * Time.deltaTime;
        }
        transform.rotation = Quaternion.Euler(roll, turn, pitch);
    }
}
