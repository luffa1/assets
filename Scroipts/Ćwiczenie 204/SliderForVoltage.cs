using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderForVoltage : MonoBehaviour
{
    public SliderForAmpers sliderAmper;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;

    void Start()
    {
        sliderAmper = GameObject.Find("Slider 1").GetComponent<SliderForAmpers>();

        slider.onValueChanged.AddListener((v) => {
            sliderText.text = v.ToString("00.0");
            sliderAmper.Voltage(v);
        });
    }

    public void Amper(float i)
    {
        float r = 13;
        float u ;
        u =  i * r;
        sliderText.text = u.ToString("00.0");
    }
}
