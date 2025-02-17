using UnityEngine;

public class InteractTracer : MonoBehaviour
{
    private MeshRenderer focusedMesh;

    private void FixedUpdate()
    {
        Vector3 start = transform.position + transform.forward;
        Vector3 fwd = transform.forward;


        if (Physics.Raycast(start, fwd, out RaycastHit hit))
        {
            if (hit.collider.tag == "Interactable")
            {
                MeshRenderer newMesh = hit.collider.GetComponent<MeshRenderer>();

                if (newMesh != focusedMesh && newMesh != null) // looking at new object
                {
                    newMesh.material.color = Color.red;
                    if (focusedMesh != null)
                    {
                        focusedMesh.material.color = Color.white;
                    }
                    focusedMesh = newMesh;
                }
                return;
            }
        }
        if (focusedMesh != null)
        {
            focusedMesh.material.color = Color.white;
            focusedMesh = null;
        }


     }
    }
