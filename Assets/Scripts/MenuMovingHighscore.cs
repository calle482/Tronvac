using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuMovingHighscore : MonoBehaviour
{

    public static float MainMenuHS;
    [SerializeField] TextMeshProUGUI HS_Text;
    // Start is called before the first frame update
    void Start()
    {
       

        // Hämtar värdet från PlayerPrefs keyen HighscoreSaved om den existerar och sätter MainMenuHS till dess värde.
        if(PlayerPrefs.HasKey("HighscoreSaved"))
        {
            MainMenuHS = PlayerPrefs.GetFloat("HighscoreSaved");
        }
    }

    // Displayar highscoren för level 2
    void Update()
    {
       HS_Text.text="Level 2 Highscore: " + MainMenuHS;
    }
}
