using TMPro;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    public float resetPoint;
    public GameObject ball;
    public float winTime;
    private float timer = 0;

    public TextMeshProUGUI gameEndLabel;
    private bool gameFinished;

    private void Update()
    {
        timer += Time.deltaTime;

        if (gameFinished == false && timer > winTime)
        {
            gameEndLabel.text = "You Win";
            gameEndLabel.color = Color.green;
            gameFinished = true;
        }


        if (gameFinished == true && Input.GetKeyDown(KeyCode.Space))
        {
            ball.transform.position = new Vector3(0, 10, 0);
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameFinished == false && other.tag == "PaddleBall")
        {
            gameEndLabel.text = "You Lose";
            gameEndLabel.color = Color.red;
            gameFinished = true;
        }
    }
}

