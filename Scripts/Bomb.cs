using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject vfxObject;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayStats>().TakeDamage(10);
            Instantiate(vfxObject, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}