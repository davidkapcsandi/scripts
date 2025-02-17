using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerBallController : MonoBehaviour
{
    public Rigidbody rBody;
    public float strength;


    private Vector3 movementInput;
    private bool jumpInput;
    private void Update()
    {
        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.z = Input.GetAxis("Vertical");

        if (jumpInput == false && Input.GetKeyDown(KeyCode.Space))
        {
            jumpInput = true;
        }

        //reset the jump button.
    }
    private void FixedUpdate()
    {
        Vector3 force = movementInput.normalized * strength;
        rBody.AddForce(force);

        if (jumpInput)
        {
            Vector3 jumpForce = Vector3.up * strength;
            rBody.AddForce(jumpForce, ForceMode.Impulse);
            jumpInput = false;
        }
    }

}
