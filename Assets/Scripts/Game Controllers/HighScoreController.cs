using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour
{
    [SerializeField]
    private Text scoreText, coinText;

    // Start is called before the first frame update
    void Start()
    {
        SetScoreBasedOnDifficulty();
    }

    void SetScore(int score,int coinScore)
    {
        scoreText.text = score.ToString();
        coinText.text = coinScore.ToString();
    }

    void SetScoreBasedOnDifficulty()
    {
        if(GamePreferences.GetEasyDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetEasyDifficultyHighScore(), GamePreferences.GetEasyDifficultyCoinScore());
        }

        if (GamePreferences.GetMediumDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetMediumDifficultyState(), GamePreferences.GetMediumDifficultyState());
        }

        if (GamePreferences.GetHardDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetHardDifficultyState(), GamePreferences.GetHardDifficultyState());
        }
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
