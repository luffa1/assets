using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public Rigidbody2D rb;  // referencja do komponentu Rigidbody2D obiektu wahadła
    public float swingForce = 5.0f;  // siła, z jaką wahadło się huśta
    public float swingPeriod = 1.0f;  // czas trwania jednego pełnego ruchu wahadła

    private Vector3 mouseOffset;  // różnica między położeniem myszy a położeniem wahadła
    private bool isDragging = false;  // czy wahadło jest aktualnie przeciągane

    // metoda wywoływana przy próbie przeciągnięcia wahadła
    void OnMouseDown()
    {
        // zapamiętaj różnicę między położeniem myszy a położeniem wahadła
        mouseOffset = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        isDragging = true;
    }

    // metoda wywoływana co klatkę, gdy wahadło jest przeciągane
    void OnMouseDrag()
    {
        // przenieś wahadło do aktualnego położenia myszy, uwzględniając różnicę położenia
        rb.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition - mouseOffset));
    }

    // metoda wywoływana, gdy przeciąganie wahadła zostaje zakończone
    void OnMouseUp()
    {
        isDragging = false;
    }

    // metoda wywoływana co klatkę
    void Update()
    {
        // jeśli wahadło nie jest przeciągane, huśtaj się zgodnie z określonymi parametrami
        if (!isDragging)
        {
            // oblicz aktualny kąt wahadła
            float angle = rb.rotation * Mathf.Deg2Rad;

            // dodaj siłę w kierunku, w którym wahadło się huśta
            rb.AddForce(new Vector2(0,0));
        }
    }
}