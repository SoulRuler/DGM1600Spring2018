using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class MoveUpDown : ScriptableObject {

    public float speed = 6.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 10.0F;
    private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

private void OnMouseDown()
{
    
        if (!controller.isGrounded) {
            moveDirection = new Vector3(0, Input.GetAxis("UpAndDown"), 0);

            // moveDirection.x = Input.GetAxis("Horizontal");

			moveDirection.y = Input.GetAxis("UpAndDown");

        	// moveDirection.z = Input.GetAxis("Vertical");

           // moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
}

    
	

}
