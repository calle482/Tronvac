using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public static float TimeLeft = 60; // Skapar floaten TimeLeft och sätter värdet till 180
    //[SerializeField] private RawImage customImage; // Skapar en RawImage vilket innebär att jag kan välja en bild som den här variabeln ska ha.
    public Text timerText; // Skapar en text som heter timerText

    //Återstället alla värden til det de ska vara i starten
    void Start()
    {
        TimeLeft = 60;
        Time.timeScale = 1;
        Score.scoreValue = 0;
        WallText.shootsFired =0;
        OpenOptions.OptionsCanvas.GetComponent<Canvas>().enabled = false;
        FPSCamera.sensitivityX = SensitivtySlider.SensSliderValue;
        FPSCamera.sensitivityY = SensitivtySlider.SensSliderValue;
    }


    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0 ) 
        {
            //Time.timeScale = 0; // Sätter time scalen till 0 så att spelet stannar
            Cursor.lockState = CursorLockMode.Locked;
            SceneManager.LoadScene("MainMenu"); // Byter till main menu scenen när tiden är över
        } 

        DisplayTime(TimeLeft); // Kallar på DisplayTime voiden varje frame. Jag gör en separat void för det istället för att lägga det i update för det ser mer clean ut.
        
    }

    // Räknar ner timern till 0 och displayar den
    void DisplayTime(float timeToDisplay)
    {
        // Gör så att timern inte kommer gå under 0
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Gör matematiken för att visa minuter i en float som heter minutes
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Gör matematiken för att visa sekunder i en float som heter sekunder

        timerText.text = string.Format("Time Left: {0:00}:{1:00}", minutes, seconds); // Detta visar upp timern på timerText texten som jag placerat på canvasen. Detta använder de 2 floatsen över för att visa minuter och sekunder
    }

}
