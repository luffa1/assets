using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmperGauge : MonoBehaviour
{
    public Slider prismaAngleSlider;
    [SerializeField] private TextMeshProUGUI amperText;
    bool shifted;
    void Start()
    {

    }
    void Update()
    {
         // wykorzystanie wzoru do obliczenia natężenia detektora dla polaryzacji 90
        SliderValue sliderValue =  SliderValue.GetInstance();
        float prismaAngle = sliderValue.GetPreviousSliderValue() * 5;
        float voltage = 7.06f;
        float detectorVoltage = prismaAngle * prismaAngle * voltage;
        prismaAngleSlider.onValueChanged.AddListener((v) =>
        {
            amperText.text = detectorVoltage.ToString("0.00");
        });
        
    }
    void Polarization0()
    {
         // wykorzystanie wzoru do obliczenia natężenia detektora dla polaryzacji 0
        SliderValue sliderValue =  SliderValue.GetInstance();
        float prismaAngle = sliderValue.GetPreviousSliderValue() * 2;
        float voltage = 7.11f;
        float detectorVoltage = prismaAngle * prismaAngle * voltage;
        
        prismaAngleSlider.onValueChanged.AddListener((v) =>
        {
            amperText.text = detectorVoltage.ToString("0.00");
        });
    }
        public void ShiftClicked()
    {
        
    }

}
