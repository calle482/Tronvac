using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrintSens : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI Sens_Text;    // Text mesh pro text som heter Sens_Text
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SensitivtySlider.SensSliderValue = Mathf.Round(SensitivtySlider.SensSliderValue * 10f) * 0.1f; // Avrundar sensitivity valuen så att det ser finare ut på sens slidern
        Sens_Text.text="" + SensitivtySlider.SensSliderValue; // Skriver ut Sensitivityn i en text
    }
}
