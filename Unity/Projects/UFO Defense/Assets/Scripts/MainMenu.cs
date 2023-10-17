using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    //Audio variables
    private AudioSource menuAudio;
    public AudioClip start;
    public AudioClip quit;

    public void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }

    //Starts the game on button click
    public void StartGame()
    {
        menuAudio.PlayOneShot(start, 0.7f);
        SceneManager.LoadScene(sceneToLoad);
    }

    //Exits the game on button click
    public void QuitGame()
    {
        menuAudio.PlayOneShot(quit, 0.7f);
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
