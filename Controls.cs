using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    public Button backButton;
    public AudioSource audio;

    void Start()
    {
        backButton = GameObject.FindGameObjectWithTag("BackButton").GetComponent<Button>();
        backButton.onClick.AddListener(Back);

        audio = GameObject.FindGameObjectWithTag("Audio3").GetComponent<AudioSource>();
        audio.Play();
    }

    public void Back()
    {
        Debug.Log("Back");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex);
    }

}
