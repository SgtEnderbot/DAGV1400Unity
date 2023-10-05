using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{
	//Variables declaring the boundaries. In scene, it seems a bit weird, but it works out.
	public float lowBound = -30.0f;
	public float topBound = 20.0f;

	void Update()
	{
	//Checking for out of bounds, destroying out of bounds object
		if(transform.position.z > topBound)
		{
		Destroy(gameObject);
		}
		else if (transform.position.z < lowBound)
		{
		Destroy(gameObject);
		}
	}
}
