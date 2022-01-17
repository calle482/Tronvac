using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuStaticHighscore : MonoBehaviour
{

    public static float MainMenuStaticHS;
    [SerializeField] TextMeshProUGUI HS_Text;
    // Start is called before the first frame update
    void Start()
    {
       

        // Hämtar värdet från PlayerPrefs keyen HighscoreStaticSaved om den existerar och sätter MainMenuStaticHS till dess värde.
        if(PlayerPrefs.HasKey("HighscoreStaticSaved"))
        {
            MainMenuStaticHS = PlayerPrefs.GetFloat("HighscoreStaticSaved");
            
        }
    }

    // Displayar highscoren för level 1
    void Update()
    {
       HS_Text.text="Level 1 Highscore: " + MainMenuStaticHS;
    }
}
