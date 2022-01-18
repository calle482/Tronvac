using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenOptions : MonoBehaviour
{



   public static Canvas OptionsCanvas;

    // Start is called before the first frame update
    void Start()
    {
       GameObject FindCanvas = GameObject.Find("Options"); // Gör ett gameobject som heter canvas och letar upp gameobjectet Options
        if(FindCanvas != null)
        {
            OptionsCanvas = FindCanvas.GetComponent<Canvas>(); // Gör så att OptionsCanvas canvasen kallar på canvas komponente
            if (OptionsCanvas ==null)
            {
                Debug.Log("DET FUCKING FUNKAR INTE"); // Ifall det inte hade funkat :)
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0; // Sätter time scalen till 0
            OptionsCanvas.GetComponent<Canvas>().enabled = true; // Laddar Ingame options canvasen
            Cursor.lockState = CursorLockMode.None; // Unlockar musen
            FPSCamera.sensitivityX = 0f; // Sätter horisontella sensitivityn till 0
            FPSCamera.sensitivityY = 0f; // Sätter vertikala sensitivityn till 0
            MenuManager.OptionsIngameCanvas.GetComponent<Canvas>().enabled = false; // Laddar ur ingame options canvasen
        }
    }
}
