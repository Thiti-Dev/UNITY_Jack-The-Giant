using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences
{
    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";

    public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
    public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
    public static string HardDifficultyHighScore = "HardDifficultyHighScore";

    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

    public static string IsMusicOn = "IsMusicOn";

    public static int GetMusicState()
    {
        return PlayerPrefs.GetInt(IsMusicOn);
    }

    public static void GetMusicState(int state)
    {
        PlayerPrefs.GetInt(IsMusicOn, state);
    }

    public static int GetEasyDifficultyState()
    {
        return PlayerPrefs.GetInt(EasyDifficulty);
    }

    public static void SetEasyDifficultyState(int state)
    {
        PlayerPrefs.SetInt(EasyDifficulty, state);
    }

    public static int GetMediumDifficultyState()
    {
        return PlayerPrefs.GetInt(MediumDifficulty);
    }

    public static void SetMediumDifficultyState(int state)
    {
        PlayerPrefs.SetInt(MediumDifficulty, state);
    }

    public static int GetHardDifficultyState()
    {
        return PlayerPrefs.GetInt(HardDifficulty);
    }

    public static void SetHardDifficultyState(int state)
    {
        PlayerPrefs.SetInt(HardDifficulty, state);
    }

    public static int GetEasyDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(EasyDifficultyHighScore);
    }
    public static void SetEasyDifficultyHighScore(int state)
    {
        PlayerPrefs.GetInt(EasyDifficultyHighScore, state);
    }

    public static int GetMediumDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(MediumDifficultyHighScore);
    }
    public static void SetMediumDifficultyHighScore(int state)
    {
        PlayerPrefs.GetInt(MediumDifficultyHighScore, state);
    }

    public static int GetHardDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(HardDifficultyHighScore);
    }
    public static void SetHardDifficultyHighscore(int state)
    {
        PlayerPrefs.GetInt(HardDifficultyHighScore, state);
    }

    public static int GetEasyDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(EasyDifficultyCoinScore);
    }
    public static void SetEasyDifficultyCoinScore(int state)
    {
        PlayerPrefs.GetInt(EasyDifficultyCoinScore, state);
    }

    public static int GetMediumDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(MediumDifficultyCoinScore);
    }
    public static void SetMeduimDifficultyCoinScore(int state)
    {
        PlayerPrefs.GetInt(MediumDifficultyCoinScore, state);
    }

    public static int GetHardDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(HardDifficultyCoinScore);
    }
    public static void SetHardDifficultyCoinScore(int state)
    {
        PlayerPrefs.GetInt(HardDifficultyCoinScore, state);
    }

}
