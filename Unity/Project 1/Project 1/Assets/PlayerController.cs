using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	float moveSpeed = 5f;
  	float jumpForce = 5f;
  	float gravity = 9.81f;
  	
	CharacterController controller;
	Vector3 moveDirection;
	bool isJumping;
	
	void Start()
	{
	controller = characterControler;
	
	GetComponent(CharacterController)
	{
		Update
		{
		Input.GetAxis("Horizontal");
		Input.GetAxis("Vertical");
		
		float horizontalInput = "Horizontal";
		float verticalInput = "Vertical";
		
		Debug.Log("Horizontal");
		Debug.Log("Vertical");
		}
	}
	}
}
