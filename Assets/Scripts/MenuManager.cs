using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Laddar scenen med stilla stående targets när man klickar på Level 1 texten
    public void buttonOnClick_Level1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Laddar scenen med rörade bollar när man klickar på Level 2 texten
     public void buttonOnClick_Level2()
    {
        SceneManager.LoadScene("MovingTargets");
    }

    // Stänger av spelet när man klickar på Quit Game texten
    public void buttonOnClick_Quit()
    {
        Application.Quit();
    }

    // Resetar highscorsen när man klickar på Reset Highscores knappen
    public void buttonOnClick_ResetHighscores()
    {
        PlayerPrefs.DeleteAll();
        MenuStaticHighscore.MainMenuStaticHS = PlayerPrefs.GetFloat("HighscoreStaticSaved");
        MenuMovingHighscore.MainMenuHS = PlayerPrefs.GetFloat("HighscoreSaved");
    }

    // Laddar how to play scenen när man klickar på how to play texten
    public void buttonOnClick_HowToPlay()
    {
         SceneManager.LoadScene("HowToPlay");
    }

    // Går tillbaka till main menu scenen när man klickar på go back texten
    public void buttonOnClick_GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ButtonOnClick_Options()
    {
        SceneManager.LoadScene("Options");
    }
}
