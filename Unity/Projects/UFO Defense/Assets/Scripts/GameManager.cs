using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    //Sets time scale and isGameOver = false
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    //Sets up the visual text
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        //Checks if isGameOver = true
        if(isGameOver)
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    //Stops the game when called
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
