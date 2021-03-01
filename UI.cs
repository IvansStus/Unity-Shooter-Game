using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //public Button playButton, aboutButton, controlsButton, quitButton;
    //public Button backButton;
    public AudioSource audio;
   
    void Start()
    {
        //playButton = GameObject.FindGameObjectWithTag("PlayButton").GetComponent<Button>();
		//playButton.onClick.AddListener(PlayGame);

        //aboutButton = GameObject.FindGameObjectWithTag("AboutButton").GetComponent<Button>();
		//aboutButton.onClick.AddListener(About);

        //controlsButton = GameObject.FindGameObjectWithTag("ControlsButton").GetComponent<Button>();
		//controlsButton.onClick.AddListener(Controls);

        //quitButton = GameObject.FindGameObjectWithTag("QuitButton").GetComponent<Button>();
		//quitButton.onClick.AddListener(Quit);

        //backButton = GameObject.FindGameObjectWithTag("BackButton").GetComponent<Button>();
		//backButton.onClick.AddListener(Back);

        audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        audio.Play();
    
    }

    public void PlayGame()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("Game Scene 1");
    }

    public void About()
    {
        Debug.Log("About");
        SceneManager.LoadScene("About");
    }
    public void Controls()
    {
        Debug.Log("Controls");
        SceneManager.LoadScene("Controls");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    public void Back()
    {
        Debug.Log("Back");
        SceneManager.LoadScene("UI");
    }
    
}
