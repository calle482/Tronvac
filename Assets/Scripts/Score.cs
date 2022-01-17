using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static float scoreValue = 0;
    Text score;


    // Kallar på text komponenten
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Visar score texten
    void Update()
    {
        score.text="Score: " + scoreValue;
    }
}
