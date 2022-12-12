using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LenghtChanges : MonoBehaviour
{
    // Suwak, którego wartość będzie używana do zmiany długości obiektu
    public Slider slider;
 

    // Stała pozycja Y obiektu
    private float fixedY;

    void Start()
    {
        // Pobierz aktualną pozycję obiektu
        Vector3 position = gameObject.transform.position;

        // Zapisz wartość pozycji Y jako stałą
        fixedY = position.y;
    }

    void Update()
    {
        // Pobierz aktualną skalę obiektu
        Vector3 scale = gameObject.transform.localScale;

        // Zmień wartość skali na osi Y na wartość suwaka
        scale.y = slider.value;

        // Ustaw nową skalę dla obiektu
        gameObject.transform.localScale = scale;

        // Pobierz aktualną pozycję obiektu
        Vector3 position = gameObject.transform.position;

        // Ustaw pozycję Y na zapisaną stałą wartość
        position.y = fixedY;

        // Ustaw nową pozycję dla obiektu
        gameObject.transform.position = position;
    }
}