using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
   
    CharacterController characterController;
    public float moveSpeed = 5f;
    private Vector3 moveDirection;
    public float sprint = 40f;
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
      float forwardInput = Input.GetAxis("Vertical");
      float rightInput = Input.GetAxis("Horizontal");
      Vector3 forward = Camera.main.transform.forward;
      Vector3 right = Camera.main.transform.right;


        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = sprint;
        }
        else
        {
            moveSpeed = 5f;
        }

        moveDirection = (forwardInput * forward) + (rightInput * right);
        moveDirection.Normalize();
        moveDirection.y = 0f;
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        
    }
    
    
}

