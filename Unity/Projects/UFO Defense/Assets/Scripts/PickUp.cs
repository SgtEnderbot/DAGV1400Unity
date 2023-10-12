using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	//Naming the object "pickUp"
	public GameObject pickUp;
	
	//Variables declaring the boundaries. In scene, it seems a bit weird, but it works out.
	public float lowBound = -30.0f;
	public float topBound = 20.0f;
	
	//Variables for movement and spawning.
	public Vector3 minPosition;
	public Vector3 maxPosition;

	//Creating a spawning timer for pick ups. A bit longer than power ups.
	public float interval = 1.0f;
	float timer;


	void Update()
	{
    
	//Setting random position for spawned pick up
	Vector3 randomPosition()
	{
	int x,y,z;
	x = Random.Range(-20, 21);
	y = Random.Range(0, 1);
	z = Random.Range(-18, -19);
	return new Vector3(x,y,z);
	}
        
	//Destroys object when out of bounds
		if(transform.position.z > topBound)
		{
		Destroy(gameObject);
		}
		else if (transform.position.z < lowBound)
		{
		Destroy(gameObject);
		}
        
        timer += Time.deltaTime;
        //Spawns pick up on a simple timer
		if (timer >= interval)
		{
		Instantiate(pickUp, randomPosition(), pickUp.transform.rotation);
		timer -= interval;
		}
	}
}
