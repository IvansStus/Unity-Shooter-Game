using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class About : MonoBehaviour
{
    public Button backButton;
    public AudioSource audio;

    void Start()
    {
        backButton = GameObject.FindGameObjectWithTag("BackButton").GetComponent<Button>();
		backButton.onClick.AddListener(Back);

        audio = GameObject.FindGameObjectWithTag("Audio2").GetComponent<AudioSource>();
        audio.Play();
    }

    public void Back()
    {
        Debug.Log("Back");
        SceneManager.LoadScene("UI");
    }

    public void Game1()
    {
        SceneManager.LoadScene("Game Scene 1");
    }
}
