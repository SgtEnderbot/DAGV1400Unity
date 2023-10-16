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

	//Pick up variables
	public int pickUps;

	public GameManager gameManager;

	void Start()
	{
		//Reference GameManager script
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        
        //Shooting lasers, creating the laser object with correct transformations
		//Checks if game is over to stop the laser from firing
        	if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        	{
        	Instantiate(laser, blaster.transform.position, laser.transform.rotation);
        	}
	}
	
	//Delete trigger ojects that collide with player
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "PowerUp")
		{
		powerUps ++;
		Debug.Log("PowerUp collision. You have " + powerUps + " power up(s).");
		Destroy(other.gameObject);
		}
		else if(other.tag == "PickUp")
		{
		pickUps ++;
		playerSpeed ++;
		Debug.Log("PickUp collision. You have " + pickUps + " pick up(s). Your speed increased.");
		Destroy(other.gameObject);
		}
	}
}
