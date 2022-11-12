using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AngleChanger : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;
    void Start()
    {
        slider.onValueChanged.AddListener((v) => {
            sliderText.text = v.ToString("0");
        });
    }
}
