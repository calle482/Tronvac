using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{

    public static float highscoreValue;
    Text HighscoreText;


    // Start is called before the first frame update
    void Start()
    {
        HighscoreText = GetComponent<Text>(); // Kallar på text komponenten

        // Hämtar värdet från PlayerPrefs keyen HighscoreSaved om den existerar och sätter highscoreValue till dess värde.
        if(PlayerPrefs.HasKey("HighscoreSaved"))
        {
            highscoreValue = PlayerPrefs.GetFloat("HighscoreSaved");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        HighscoreValue();
        HighscoreTextOutput();
    }

        // Sätter highscore till score värdet om score är större än highscore. Sparar också det i en PlayerPrefs Key så att jag kan spara värdet mellan sessions
        void HighscoreValue()
        {
            
             if (Score.scoreValue > highscoreValue)
            {
                 highscoreValue = Score.scoreValue;

                 PlayerPrefs.SetFloat("HighscoreSaved", highscoreValue);
             }

        }

        // Skriver ut highscore valuen på skärmen
        void HighscoreTextOutput()
        {
            HighscoreText.text="Highscore: " + highscoreValue;  
        }

    

    




}
