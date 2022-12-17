using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPosition : MonoBehaviour
{
    // Obiekt, od którego zależy obrót tego obiektu
    public Transform target;
    // Kąt obrotu ciężarków na początku gry
    public float startAngle = 0f;

    void Update()
    {
        if (transform.position.y != target.position.y)
        {
        // Oblicz kąt obrotu w radianach na podstawie pozycji obiektu i celu
        float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) + startAngle;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Mathf.Rad2Deg * angle);

        }
    }
}


// Rigidbody2D rb = pendulum.GetComponent<Rigidbody2D>();
//         Vector2 force = -rb.velocity * rb.mass;
//         rb.AddForce(force);


        // // // Obróć obiekt o odpowiedni kąt
        // transform.RotateAround(transform.position, Vector3.forward, Mathf.Rad2Deg * angle - transform.eulerAngles.z);