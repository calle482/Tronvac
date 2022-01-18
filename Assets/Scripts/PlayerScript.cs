using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    int speed = 6; // Skapar en int som heter speed

    // Update is called once per frame
    void start ()
    {
        
    }
    
    void Update()
    {
        // Git test
        Movement();
        SceneSwitch();
        Debug.Log(SensitivtySlider.SensSliderValue);
    }


        void SceneSwitch()
        {
        //Byter scenen till Main menu och låser upp musen när man klickar esc
         if (Input.GetKeyDown(KeyCode.Escape))
        {
           // SceneManager.LoadScene("MainMenu");

           // Cursor.lockState = CursorLockMode.None;
          //  FPSCamera.sensitivityX = 0;
          //  FPSCamera.sensitivityY = 0;
        }
        }

        void Movement ()
    {
        // Player Movement
        if (Input.GetKey("w")) transform.Translate(Vector3.forward * speed * Time.deltaTime); // Gå frammåt
        if (Input.GetKey("s")) transform.Translate(Vector3.back * speed * Time.deltaTime); // Gå backåt
        if (Input.GetKey("a")) transform.Translate(Vector3.left * speed * Time.deltaTime); // Gå vänster
        if (Input.GetKey("d")) transform.Translate(Vector3.right * speed * Time.deltaTime); // Gå höger
    }
}
