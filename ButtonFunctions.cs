using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Game Scene");
    }
    public void settingScene()
    {
        SceneManager.LoadScene("Settings");
    }
    public void backButtonBehavior()
    {
        SceneManager.LoadScene("UI");
    }
    public void nextButtonBehavior()
    {
        SceneManager.LoadScene("Controls");
    }
    public void backControlButton()
    {
        SceneManager.LoadScene("Intro");
    }
    public void gamePlayButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void gameCreditsButton()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    public void gameControlButton()
    {
        SceneManager.LoadScene("Controls");
    }
    public void ControlsNext()
    {
        SceneManager.LoadScene("GameObjs");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
