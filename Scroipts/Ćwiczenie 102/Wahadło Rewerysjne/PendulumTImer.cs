using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumTImer : MonoBehaviour
{
    // Zmienna do przechowywania czasu od momentu, gdy wahadło zaczyna spadać
    private float fallingTime;

    // Zmienna do przechowywania położenia wahadła w momencie startu liczenia czasu
    private Vector3 startingPosition;

    void Update()
    {
        // Pobierz aktualne położenie wahadła
        Vector3 currentPosition = transform.position;

        // Jeśli aktualne położenie wahadła jest niższe niż położenie początkowe,
        // rozpocznij liczenie czasu
        if (currentPosition.y < startingPosition.y)
        {
            // Zwiększ zmienną fallingTime o czas, który upłynął od ostatniej klatki
            fallingTime += Time.deltaTime;
        }
    }
}