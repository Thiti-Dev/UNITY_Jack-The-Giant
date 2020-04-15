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
            Debug.Log($"Trying to set the highscore of easy, score : {GamePreferences.GetEasyDifficultyHighScore()} , coin : {GamePreferences.GetEasyDifficultyCoinScore()}");
            SetScore(GamePreferences.GetEasyDifficultyHighScore(), GamePreferences.GetEasyDifficultyCoinScore());
        }

        if (GamePreferences.GetMediumDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetMediumDifficultyHighScore(), GamePreferences.GetMediumDifficultyCoinScore());
        }

        if (GamePreferences.GetHardDifficultyState() == 1)
        {
            SetScore(GamePreferences.GetHardDifficultyHighScore(), GamePreferences.GetHardDifficultyCoinScore());
        }
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
