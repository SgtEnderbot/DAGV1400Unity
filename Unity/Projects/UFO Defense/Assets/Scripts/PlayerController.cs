using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//Movement variables
	public float horizontalInput;
	public float playerSpeed;
	public float xRange;

	//Laser variables
	public Transform blaster;
	public GameObject laser;
	
	//Power up variables
	public int powerUps;
	public GameObject powerUp;
	 
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
        
        //Shooting lasers, creating the laser object with correct transformations
        	if(Input.GetKeyDown(KeyCode.Space))
        	{
        	Instantiate(laser, blaster.transform.position, laser.transform.rotation);
        	}
	}
	
	//Delete trigger ojects that collide with player
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == powerUp)
		{
		Destroy(other.gameObject);
		powerUps ++;
		Debug.Log("PowerUp collision. You have " + powerUps + " power ups.");
		}
		else
		{
		Destroy(other.gameObject);
		Debug.Log("Object collision");
		}	
	}
}
