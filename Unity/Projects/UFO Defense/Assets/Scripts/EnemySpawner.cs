using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	//Array storing UFO types
	public GameObject[] ufoPrefabs;

	//Variables for spawning UFOs at random positions and at a specified interval
	float spawnRangeX = 20.0f;
	float spawnPositionZ = -20.0f;
	float startDelay = 2.0f;
	float lowInterval = 1.0f;
	float highInterval = 2.0f;

		void Start()
		{
			//Spawns UFOs at a random interval between lowInterval and highInterval
			InvokeRepeating("SpawnRandomUFO", startDelay, Random.Range(lowInterval, highInterval));
		}

    	void Update()
		{
			//Spawns a UFO when S is pressed
			if(Input.GetKeyDown(KeyCode.S))
			{
			SpawnRandomUFO();
			}
		}
	
	//Function for spawning UFOs at random positions
	void SpawnRandomUFO()
	{
		Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
		int ufoIndex = Random.Range(0,ufoPrefabs.Length);
		Instantiate(ufoPrefabs[ufoIndex], spawnPosition, ufoPrefabs[ufoIndex].transform.rotation);
	}
}
