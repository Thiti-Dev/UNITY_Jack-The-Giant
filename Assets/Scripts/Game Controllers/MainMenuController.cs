﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        GameManager.instance.gameStartedFromMainMenu = true;
        Debug.Log(GameManager.instance.gameStartedFromMainMenu);
    }

    public void HignScoreMenu()
    {
        SceneManager.LoadScene("HighScoreScene");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MusicButton()
    {

    }
}
