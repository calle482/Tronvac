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
        Cursor.lockState = CursorLockMode.Locked; // Låser muspekaren
    }
    
    void Update()
    {
        Movement();
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
