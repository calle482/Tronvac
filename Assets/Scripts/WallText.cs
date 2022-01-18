using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallText : MonoBehaviour
{
    float accuracyValue;
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
        accuracyValue = Score.scoreValue / shootsFired * 100; // Räknar ut accuracy
        accuracyValue = Mathf.Round(accuracyValue * 10f) * 0.1f; // Avrundar accuracy valuen så att det ser finare ut på sens slidern
        missed.text="Accuracy: " + accuracyValue + "%"; // Skriver ut accuracyn med ett % efter
    }
}
