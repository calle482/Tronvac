using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{

    public static Canvas OptionsIngameCanvas;
    // Start is called before the first frame update
    void Start()
    {
        

       GameObject FindCanvas = GameObject.Find("OptionsMenu");
        if(FindCanvas != null)
        {
            OptionsIngameCanvas = FindCanvas.GetComponent<Canvas>();
            if (OptionsIngameCanvas ==null)
            {
                Debug.Log("DET FUCKING FUNKAR INTE");
            }
        }
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
        FPSCamera.sensitivityX = SensitivtySlider.SensSliderValue;
        FPSCamera.sensitivityY = SensitivtySlider.SensSliderValue;
    }
    // Laddar options scenen
    public void ButtonOnClick_Options()
    {
        SceneManager.LoadScene("Options");
    }
    // Resume knappen i menyn ingame
    public void buttonOnClick_Resume()
    {
        // Hämtar värdet från keyen SensSaved till floaten SensSliderValue
        if(PlayerPrefs.HasKey("SensSaved"))
        {
           SensitivtySlider.SensSliderValue = PlayerPrefs.GetFloat("SensSaved");
        }

        FPSCamera.sensitivityX = SensitivtySlider.SensSliderValue; // Sätter tillbaka den vertikala sensitivityn till det spelaren valt
        FPSCamera.sensitivityY = SensitivtySlider.SensSliderValue; // Sätter tillbaka den vertikala sensitivityn till det spelaren valt
        OpenOptions.OptionsCanvas.GetComponent<Canvas>().enabled = false; // Slutar rendera ingame menyn canvasen
        OptionsIngameCanvas.GetComponent<Canvas>().enabled = false; // Slutar rendera ingame options canvasen
        Time.timeScale = 1; // Sätter timescale till 1
        Cursor.lockState = CursorLockMode.Locked; // Gör så att man inte kan röra runt muspekaren
    }
    // Laddar ingame options menyn
    public void buttonOnClick_OptionsIngame()
    {
         OptionsIngameCanvas.GetComponent<Canvas>().enabled = true; // Laddar ingame options canvasen
         OpenOptions.OptionsCanvas.GetComponent<Canvas>().enabled = false; // Laddar ur ingame menyn
    }
    //Går tillbaka till ingame menyn
    public void buttonOnClick_GoBackOptions()
    {
        OptionsIngameCanvas.GetComponent<Canvas>().enabled = false; // Laddar ur ingame options canvasen
        OpenOptions.OptionsCanvas.GetComponent<Canvas>().enabled = true; // Laddar ingame menyn
    }
}
