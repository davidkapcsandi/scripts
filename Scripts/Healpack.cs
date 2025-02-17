using UnityEngine.UI;
using UnityEngine;

public class Healpack : MonoBehaviour
{
    public GameObject healObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayStats>().GetHeal(5);
            Instantiate(healObject, transform.position, Quaternion.identity);
            Destroy(healObject);
        }
    }
}
