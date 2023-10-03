using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
	//Variables declaring the boundaries.
	public float lowBound = -30.0f;
	public float topBound = 20.0f;
	
	void Awake()
	{
	//Time.timeScale = 1;	
	}
	void Update()
	{
	//Checking for out of bounds, destroying out of bounds object
		if(transform.position.z > topBound)
		{
		Destroy(gameObject);
		}
		else if (transform.position.z < lowBound)
		{
		Debug.Log("Game Over.");
		Destroy(gameObject);
		//Time.timeScale = 0;
		}
	}
}
