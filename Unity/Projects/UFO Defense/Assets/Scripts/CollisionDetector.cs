using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    //Store the score manager reference
    public ScoreManager scoreManager;

    public int scoreToGive;

    void Start()
    {
        //Find ScoreManager gameobject and reference ScoreManager script
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    //Detects when colliding with another object and determines if it is a laser. If so, it destroys both objects and increases the score.
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Laser")
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
