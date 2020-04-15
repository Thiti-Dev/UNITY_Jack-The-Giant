using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private Button musicBtn;

    [SerializeField]
    private Sprite[] musicIcons;
    // Start is called before the first frame update
    void Start()
    {
        CheckToPlayTheMusic();
    }

    void CheckToPlayTheMusic()
    {
        if(GamePreferences.GetMusicState() == 1)
        {
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[1];
        }
        else
        {
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[0];
        }
    }

    public void StartGame()
    {
        GameManager.instance.gameStartedFromMainMenu = true;
        SceneManager.LoadScene("Gameplay");
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
        if(GamePreferences.GetMusicState() == 0)
        {
            GamePreferences.SetMusicState(1);
            CheckToPlayTheMusic();
        }
        else
        {
            GamePreferences.SetMusicState(0);
            CheckToPlayTheMusic();
        }
    }
}
