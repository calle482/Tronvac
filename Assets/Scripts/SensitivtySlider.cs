using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivtySlider : MonoBehaviour
{

    public Slider SensSlider;
    public static float SensSliderValue = 4f;

    // Start is called before the first frame update
    void Start()
    {
        SensSlider.maxValue = 10f; // Sätter max valuen för sensitivity slidern
        SensSlider.minValue = 1f; // Sätter min valuen för sensitivity slidern
        SensSlider.value = SensSliderValue; // Sparar sensivity sliderns value i en float

        // Hämtar sensen från "SensSaved" keyen om den finns
        if(PlayerPrefs.HasKey("SensSaved"))
        {
            SensSlider.value = PlayerPrefs.GetFloat("SensSaved");
        }
    }



    // Update is called once per frame
    void Update()
    {
        SensSliderValue = SensSlider.value; // Sätter floaten till värder av sensitivity slidern
        PlayerPrefs.SetFloat("SensSaved", SensSliderValue); // Sparar floatens värde i en key

    }

}
