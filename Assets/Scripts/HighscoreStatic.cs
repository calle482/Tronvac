using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreStatic : MonoBehaviour
{

    public static float highscoreValueStatic;
    public static Text HighscoreText;


    // Start is called before the first frame update
    void Start()
    {
        HighscoreText = GetComponent<Text>(); // Kallar på text komponenten

        // Hämtar värdet från PlayerPrefs keyen HighscoreStaticSaved om den existerar och sätter highscoreValueStatic till dess värde.
        if(PlayerPrefs.HasKey("HighscoreStaticSaved"))
        {
            highscoreValueStatic = PlayerPrefs.GetFloat("HighscoreStaticSaved");
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
            
             if (Score.scoreValue > highscoreValueStatic)
            {
                 highscoreValueStatic = Score.scoreValue;

                 PlayerPrefs.SetFloat("HighscoreStaticSaved", highscoreValueStatic);
             }

        }

        // Skriver ut highscore valuen på skärmen
        void HighscoreTextOutput()
        {
            HighscoreText.text="Highscore: " + highscoreValueStatic;  
        }

    

    




}
