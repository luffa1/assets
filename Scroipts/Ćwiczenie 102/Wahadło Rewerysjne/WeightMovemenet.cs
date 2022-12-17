using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeightMovemenet : MonoBehaviour
{
    // Referencja do obiektu suwaka
    public Slider slider;
    public TextMeshProUGUI sliderValue;

    // Komponent Transform obiektu, dla którego chcemy zmieniać wartość Y
    private Transform targetTransform;

    void Start()
    {
        // Pobranie komponentu Transform obiektu, dla którego chcemy zmieniać wartość Y
        targetTransform = GetComponent<Transform>();

        // Nasłuchiwanie zdarzenia zmiany pozycji suwaka
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Funkcja wywoływana po zmianie pozycji suwaka
    void OnSliderValueChanged(float value)
    {
        // Ustawienie nowej wartości Y dla obiektu
        targetTransform.position = new Vector3(targetTransform.position.x, value, targetTransform.position.z);
        float displayedValue = Mathf.Abs(slider.value * 5);
        sliderValue.text = displayedValue.ToString("");
    }
}