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
        SensSlider.maxValue = 10f;
        SensSlider.minValue = 1f;
        SensSlider.value = SensSliderValue;

        if(PlayerPrefs.HasKey("SensSaved"))
        {
            SensSlider.value = PlayerPrefs.GetFloat("SensSaved");
        }
    }



    // Update is called once per frame
    void Update()
    {
        SensSliderValue = SensSlider.value;
        FPSCamera.sensitivityX = SensSliderValue;
        FPSCamera.sensitivityY = SensSliderValue;
        PlayerPrefs.SetFloat("SensSaved", SensSliderValue);

    }

}
