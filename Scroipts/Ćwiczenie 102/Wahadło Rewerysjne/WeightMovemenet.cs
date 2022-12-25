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
    // Tablica zawierająca wartości wyświetlane dla poszczególnych pozycji suwaka
    private string[] displayedValues = { "90", "85", "75", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10"};

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
        // Ustawienie nowej wartości Y dla obiektu
        targetTransform.position = new Vector3(targetTransform.position.x, value, targetTransform.position.z);

         // Pobranie indeksu tablicy odpowiadającego pozycji suwaka
        int arrayIndex = (int)value + displayedValues.Length / 2;

        // Sprawdzenie, czy indeks jest w zakresie dostępnych wartości
        if (arrayIndex >= 0 && arrayIndex < displayedValues.Length)
        {
            // Ustawienie wyświetlanej wartości jako element tablicy o odpowiednim indeksie
            sliderValue.text = displayedValues[arrayIndex] + " cm";
        }

        // float displayedValue = Mathf.Abs(slider.value * 5);
        // sliderValue.text = displayedValue.ToString("");
    }
}