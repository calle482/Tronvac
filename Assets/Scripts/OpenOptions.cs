using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenOptions : MonoBehaviour
{



   public Canvas Options;

    // Start is called before the first frame update
    void Start()
    {
        //CanvasOptions = GameObject.FindGameObjectsWithTag("OptionsCanvas");
    }

    // Update is called once per frame
    void Update()
    {
                 if (Input.GetKeyDown(KeyCode.Escape))
        {
           // SceneManager.LoadScene("MainMenu");
            Options.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            FPSCamera.sensitivityX = 0;
            FPSCamera.sensitivityY = 0;
        }
    }
}
