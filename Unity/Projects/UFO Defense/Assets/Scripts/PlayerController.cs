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

	//Sound variables
	public AudioClip laserShot;
	public AudioClip powerUpSound;
	public AudioClip pickUpSound;
	private AudioSource playerAudio;

	//Allowing use of GameManager script
	public GameManager gameManager;

	void Start()
	{
		//Reference GameManager script
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		//Set up audio source
		playerAudio = GetComponent<AudioSource>();
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
			playerAudio.PlayOneShot(laserShot, 0.7f);
        	}
	}
	
	//Delete trigger ojects that collide with player
	private void OnTriggerEnter(Collider other)
	{
		//Deletes PowerUp on collision. Logs that you have a power up. Plays the Power Up sound.
		if(other.tag == "PowerUp")
		{
		powerUps ++;
		Debug.Log("PowerUp collision. You have " + powerUps + " power up(s).");
		playerAudio.PlayOneShot(powerUpSound, 1.0f);
		Destroy(other.gameObject);
		}
		//Deletes PickUp on collision. Logs that you have a pick up and increased speed. Plays the Pick Up sound.
		else if(other.tag == "PickUp")
		{
		pickUps ++;
		playerSpeed ++;
		Debug.Log("PickUp collision. You have " + pickUps + " pick up(s). Your speed increased.");
		playerAudio.PlayOneShot(pickUpSound, 1.0f);
		Destroy(other.gameObject);
		}
	}
}
