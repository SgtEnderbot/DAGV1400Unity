using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
	public float speed = 50.0f;
	
	void Update()
	{
	
	//Moves object forward
	transform.Translate(Vector3.forward * Time.deltaTime * speed);
	
	}
}
