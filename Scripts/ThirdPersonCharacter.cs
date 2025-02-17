using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacter : MonoBehaviour
{
    public Animator animator;
    public Transform cam;
    public float speed = 2.0f;
    private bool attackInput;

    private CharacterController controller;
    private Vector3 movementInput;
    private Quaternion cameraRotation;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {

        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.z = Input.GetAxis("Vertical");

        Vector3 finalDir = Quaternion.Euler(0, cam.eulerAngles.y, 0) * movementInput;

        controller.SimpleMove(finalDir * speed);

        //Update animator parameters
        animator.SetFloat("Forward", movementInput.z);
        animator.SetFloat("Right", movementInput.x);
        animator.SetBool("isGrounded", controller.isGrounded);
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
    
        {
            controller.Move(Vector2.up * 5);
            animator.SetTrigger("Jump");
        }
        else
        {
            controller.SimpleMove(finalDir * speed);
        }
        
      }

  }
