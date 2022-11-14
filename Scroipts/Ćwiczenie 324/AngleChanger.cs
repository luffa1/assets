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
        float sliderDisplay = v * 5;
        consumption.UpdatePosition(v); 
        sliderText.text = sliderDisplay.ToString("0");
        Debug.Log(v);
        });
    }
}
