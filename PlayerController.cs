using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	CharacterController controller;
	float playerSpeed = 5.0f;
  	float jumpHeight = 2.0f;
  	float gravityValue = -9.81f;
	Vector3 playerVelocity;
	bool groundedPlayer;
	
	void Start()
	{
	controller = gameObject.AddComponent<CharacterController>();
	}
	
	void Update()
	{
	groundedPlayer = controller.isGrounded;
		if (groundedPlayer && playerVelocity.y < 0)
		{
		playerVelocity.y = 0f;
		}
		
	Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	controller.Move(move * Time.deltaTime * playerSpeed);
	
		if (move != Vector3.zero)
		{
	   	gameObject.transform.forward = move;
		}

		if (Input.GetButtonDown("Jump") && groundedPlayer)
		{
		playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
		}

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
	}
}
