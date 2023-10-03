using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	//Movement Variables
	CharacterController controller;
	float playerSpeed = 3.0f;
	float playerHeight = 2.0f;
	float jumpHeight = 2.0f;
	float gravityValue = -9.81f;
	Vector3 playerVelocity;
	bool groundedPlayer;
	float speedMultiplier = 1.0f;

	//Crouching Variables
	bool isCrouching = false;
	float crouchHeight = 1.5f;
	float crouchSpeedMultiplier = 0.5f;
	
	//Sprinting Variables
	bool isSprinting = false;
	float sprintSpeedMultiplier = 2.0f;

	void Start()
	{
	controller = gameObject.AddComponent<CharacterController>();
	}

	void FixedUpdate()
	{
    
	//Movement
        groundedPlayer = controller.isGrounded;
		if (groundedPlayer && playerVelocity.y < 0)
		{
		playerVelocity.y = 0f;
		}
		
	float horizontalInput = Input.GetAxis("Horizontal");
	float verticalInput = Input.GetAxis("Vertical");

	Vector3 moveDirection = Camera.main.transform.forward * verticalInput + Camera.main.transform.right * horizontalInput;
	moveDirection.y = 0;


	speedMultiplier = isSprinting ? sprintSpeedMultiplier : (isCrouching ? crouchSpeedMultiplier : 1.0f);

	controller.Move(moveDirection.normalized * playerSpeed * speedMultiplier * Time.deltaTime);
	
	//Calculating speed based on movement type
		if (isSprinting && !isCrouching)
		{
		speedMultiplier = sprintSpeedMultiplier;
		}
		else if (isCrouching)
		{
		speedMultiplier = crouchSpeedMultiplier;
		}

	controller.Move(moveDirection.normalized * Time.fixedDeltaTime * playerSpeed * speedMultiplier);

		if (Input.GetButtonDown("Jump") && groundedPlayer)
		{
		playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
		}

	playerVelocity.y += gravityValue * Time.fixedDeltaTime;
	controller.Move(playerVelocity * Time.fixedDeltaTime);
        
        
        //Crouching
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
		isCrouching = true;
		controller.height = crouchHeight;
		}
		else if (Input.GetKeyUp(KeyCode.LeftControl))
		{
		isCrouching = false;
		controller.height = playerHeight;
		}
	
	
	//Sprinting
		if (Input.GetKeyDown(KeyCode.LeftShift) && !isCrouching)
        	{
        	isSprinting = true;
        		for (float i = 3.0f; i == playerSpeed;)
        		{
        		playerSpeed *= sprintSpeedMultiplier;
        		}
        	}
        	else if (Input.GetKeyUp(KeyCode.LeftShift) && !isCrouching)
        	{
        	isSprinting = false;
        		for (float i = 3.0f; i != playerSpeed;)
        		{
        		playerSpeed /= sprintSpeedMultiplier;
        		}
        	}
        	
	}
}
