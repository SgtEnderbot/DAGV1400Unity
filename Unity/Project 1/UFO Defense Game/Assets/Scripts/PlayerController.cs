using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
	public float playerSpeed;
	public float xRange;
	 
	void Start()
	{

	}


	void Update()
	{
	
	//Initialization and movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
        
        
        //Keeps player within bounds
        //Left side
        	if(transform.position.x < -xRange)
        	{
		transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        	}
        //Right side
                if(transform.position.x > xRange)
        	{
		transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        	}
	}
}
