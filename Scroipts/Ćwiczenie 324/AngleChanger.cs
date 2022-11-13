using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AngleChanger : MonoBehaviour
{
    public CurrentConsumption consumption;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;

 void Start()
    {
        consumption = GameObject.Find("Detektor").GetComponent<CurrentConsumption>();

        slider.onValueChanged.AddListener((v) => {
        double p = System.Math.Round(v / 5.0) * 5;
        consumption.UpdatePosition(p); 
        sliderText.text = p.ToString("0");
        });
    }
}
