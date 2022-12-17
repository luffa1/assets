using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionConstraint : MonoBehaviour
{
    public Transform pivot; // obiekt, względem którego ograniczamy pozycję
    public float maxDistance; // maksymalna odległość od obiektu pivot

    // void Update()
    // {
    //     // pobierz pozycję obiektu
    //     Vector2 position = transform.position;
    //     // pobierz pozycję obiektu pivot jako Vector2
    //     Vector2 pivotPosition = new Vector2(pivot.position.x, pivot.position.y);
    //     // oblicz odległość od obiektu pivot w pikselach
    //     float distance = Vector2.Distance(position, pivotPosition);

    //     // jeśli odległość jest większa niż maksymalna, ogranicz pozycję
    //     if (distance > maxDistance)
    //     {
    //         Vector2 direction = (position - pivotPosition).normalized;
    //         position = pivotPosition + direction * distance;
    //         transform.position = position;
    //     }
    // }


    // public float liftForce; // siła unoszenia

    // void Update()
    // {
    //     // pobierz pozycję obiektu
    //     Vector2 position = transform.position;

    //     // pobierz pozycję obiektu pivot jako Vector2
    //     Vector2 pivotPosition = new Vector2(pivot.position.x, pivot.position.y);

    //     // oblicz odległość od obiektu pivot w pikselach
    //     float distance = Vector2.Distance(position, pivotPosition);

    //     // jeśli odległość jest większa niż maksymalna, ogranicz pozycję
    //     if (distance > maxDistance)
    //     {
    //         // oblicz kierunek do pivot
    //         Vector2 direction = (position - pivotPosition).normalized;

    //         // ustaw pozycję na maxDistance od pivot
    //         position = pivotPosition + direction * maxDistance;
    //         transform.position = position;

    //         // dodaj siłę unoszenia, aby unieść obiekt do góry
    //         GetComponent<Rigidbody2D>().AddForce(Vector2.up * liftForce);
    //     }
    
        void Update()
        {
            // pobierz pozycję obiektu
            Vector2 position = transform.position;

            // pobierz pozycję obiektu pivot jako Vector2
            Vector2 pivotPosition = new Vector2(pivot.position.x, pivot.position.y);

            // oblicz odległość od obiektu pivot w pikselach
            float distance = Vector2.Distance(position, pivotPosition);

            // jeśli odległość jest większa niż maksymalna, ogranicz pozycję
            if (distance > maxDistance)
            {
                // oblicz kierunek do pivot
                Vector2 direction = (position - pivotPosition).normalized;

                // ustaw pozycję na maxDistance od pivot
                position = pivotPosition + direction * maxDistance;
                transform.position = position;

                // pobierz komponent Rigidbody2D
                Rigidbody2D rb = GetComponent<Rigidbody2D>();

                // ustaw prędkość na zero
                rb.velocity = Vector2.zero;
            }
        }
}

