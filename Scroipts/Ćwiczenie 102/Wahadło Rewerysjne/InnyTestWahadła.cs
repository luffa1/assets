using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InnyTestWahadła : MonoBehaviour
{
    // public float swingSpeed = 1; // speed at which the pendulum swings
    // public float swingAngle = 45; // maximum angle at which the pendulum can swing
    // public float damping = 0.1f; // damping factor to slow down the pendulum over time

    public Rigidbody2D rb; // rigidbody component attached to the pendulum
    public float force = 0; // default force value
    public InputField swingForceInput; // input field for setting the force value
    public Button applyForceButton; // button for applying the force

    void Start()
    {
        // Set up a listener for the button's "onClick" event
        applyForceButton.onClick.AddListener(ApplyForce);
    }
    void Update()
    {
        // // Calculate the current swing angle of the pendulum based on its position and velocity
        // float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;

        // // Limit the swing angle to the maximum angle
        // angle = Mathf.Clamp(angle, -swingAngle, swingAngle);

        // // Calculate the force to apply to the pendulum based on the swing angle and speed
        // Vector2 force = Vector2.right * Mathf.Sin(angle * Mathf.Deg2Rad) * swingSpeed;

        // // Apply damping to slow down the pendulum over time
        // force -= rb.velocity * damping;

        // // Apply the calculated force to the pendulum
        // rb.AddForce(force, ForceMode2D.Force);
    }
    void ApplyForce()
    {
        // Check if the user has entered a value in the input field
        if (swingForceInput != null && !string.IsNullOrEmpty(swingForceInput.text))
        {
            // Parse the input value and set the force variable
            float.TryParse(swingForceInput.text, out force);

            // Apply the force to the pendulum
            rb.AddForce(Vector2.right * force, ForceMode2D.Impulse);
        }
    }
}





 // // właściwości fizyczne wahadła
    // public float angle = 0f;  // kąt wahadła
    // public float angularVelocity = 0f;  // prędkość kątowa
    // // Prędkość wahadła
    // public float speed = 1f;

    // // Kierunek działania siły grawitacji
    // public Vector2 direction = Vector2.down;

    // void Update()
    // {
        
        // // metoda obliczająca ruch wahadła

        // // obliczenie przyspieszenia kątowego zgodnie z równaniem ruchu wahadła
        // float angularAcceleration = -gravity * Mathf.Sin(angle) / length;

        // // aktualizacja prędkości kątowej i kąta wahadła
        // angularVelocity += angularAcceleration * Time.deltaTime;
        // angle += angularVelocity * Time.deltaTime;

        // // obliczenie pozycji końca wahadła
        // float x = length * Mathf.Sin(angle);
        // float y = length * Mathf.Cos(angle);

        // // ustawienie pozycji końca wahadła w odpowiednim miejscu
        // transform.position = new Vector3(x, y, 0);

        // // obrót wahadła w odpowiednim kierunku
        // float rotationZ = angle * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        
    //     // Obliczenie nowej pozycji wahadła
    //     Vector2 newPos = (transform.position + direction * speed * Time.deltaTime);

    //     // Zmiana pozycji wahadła
    //     transform.position = newPos;

    //     // Sprawdzenie, czy wahadło osiągnęło krańcową pozycję
    //     // i zmiana kierunku ruchu w razie potrzeby
    //     if (transform.position.y <= 0)
    //     {
    //         direction = Vector2.up;
    //     }
    //     else if (transform.position.y >= 5)
    //     {
    //         direction = Vector2.down;
    //     }
    // }