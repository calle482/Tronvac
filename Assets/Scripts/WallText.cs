using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallText : MonoBehaviour
{

    public static float shootsFired = 0;
    Text missed;


    // Kallar på text komponenten
    void Start()
    {
        missed = GetComponent<Text>();
    }

    // Gör mattematiken för accuracyn och displayar accuracy texten
    void Update()
    {
        missed.text="Accuracy: " + Score.scoreValue / shootsFired * 100;
    }
}
