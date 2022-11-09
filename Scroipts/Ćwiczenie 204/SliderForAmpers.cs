using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderForAmpers : MonoBehaviour
{
    public SliderForVoltage sliderVoltage;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;


    void Start()
    {
        sliderVoltage = GameObject.Find("Slider 2").GetComponent<SliderForVoltage>();
        
        slider.onValueChanged.AddListener((v) => {
            sliderText.text = v.ToString("0.00");
            sliderVoltage.Amper(v);
        });
    }

    // Funkcja odpowiadająca za zwiększanie się amperów według wzoru
    public void Voltage(float u)
    {
        float r = 13;
        float i ;
        i =  u / r;
        sliderText.text = i.ToString("0.00");
    }
}


