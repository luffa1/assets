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
        SkryptObliczeniowy skrypt = new SkryptObliczeniowy();
        sliderText.text = skrypt.CalculateVoltage(i).ToString("00.0");
    }
      public void DisplayAmperGauge(float u)
    {
        SkryptObliczeniowy skrypt = new SkryptObliczeniowy();
        sliderText.text = skrypt.CalculateAmper(u).ToString("0.000");
    }
}
