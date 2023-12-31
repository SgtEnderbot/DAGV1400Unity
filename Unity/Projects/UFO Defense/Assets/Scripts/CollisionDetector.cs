using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    //Store the score manager reference
    public ScoreManager scoreManager;

    //Gives the signal to increase score
    public int scoreToGive;

    //Audio variables
    private AudioSource ufoAudio;
    public AudioClip boom;

    void Start()
    {
        //Find ScoreManager gameobject and reference ScoreManager script
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        ufoAudio = GetComponent<AudioSource>();
    }
    //Detects when colliding with another object and determines if it is a laser. If so, it destroys both objects and increases the score.

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Laser")
        {
            scoreManager.IncreaseScore(scoreToGive);
            ufoAudio.PlayOneShot(boom, 0.7f);
            Destroy(other.gameObject);
            Destroy(gameObject, 0.3f);
        }
    }
}
