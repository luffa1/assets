using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TestingCodeForMovement : MonoBehaviour
{
    // Masa wahadła
    public float mass = 1.0f;

    // Długość ramienia wahadła
    public float length = 12.3f;

    // Siła grawitacji
    public float gravity = 9.81f;

    // Siła poruszająca wahadło po kliknięciu
    public float force = 0;
    // Komponent Rigidbody2D obiektu wahadła
    private Rigidbody2D rb;
    // public ReversePendulumTimer timer;
    public InputField swingForceInput;
    public Button startButton;
    public TextMeshProUGUI periodDisplayer;
    private float currentTime;
    private int period = 0; // added period counter variable
    public int count = 0;
    private bool countingPeriod = false;  // Flaga informująca o tym, czy zliczanie okresu jest włączone
    private float initialRotation;
    private float previousTime;
    private float time = 0;
    public float timer;
    
    public float amplitude;
    public Transform pendulum;

    public ReversePendulumTimer timerr;

    void Start()
    {

        timerr = GameObject.Find("ReversePendulumTimer").GetComponent<ReversePendulumTimer>();
        // Pobranie komponentu Rigidbody2D obiektu wahadła
        rb = GetComponent<Rigidbody2D>();
        startButton.onClick.AddListener(ApplyForce);

        // Ustawienie masy wahadła
        rb.mass = mass;
        // Ustawienie siły grawitacji
        rb.gravityScale = gravity;
    }

    void Update()
    {  

        Period.GetInstance().SetNewCurrentPosition(pendulum.position.x);
        periodDisplayer.text = Period.GetInstance().GetPeriod().ToString();

        Debug.Log(Period.GetInstance().GetPeriod());
        if (Period.GetInstance().deviationCounter == 0)
        {
            if(!timerr.isStarted)
            {
                timerr.startTimer();
            }
        }
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



   






 









// // Zmienna przechowująca aktualną pozycję wahadła
// private float currentPosition;
// // Zmienna przechowująca poprzednią pozycję wahadła
// private float previousPosition;
// // Zmienna przechowująca liczbę przebytych okresów
// private int periodsCounter = 0;


//     // Zapisanie aktualnej pozycji jako poprzednią
//     previousPosition = rb.transform.eulerAngles.z;

// void Update()
// {
//     // Pobranie aktualnej pozycji
//     currentPosition = rb.transform.eulerAngles.z;
//     // Obliczenie różnicy międ









    // // Define the conditions for a reverse pendulum
    //     bool ReversePendulumConditions()
    //     {
    //         if (pendulumAngle < 0 || pendulumVelocity < 0)
    //         {
    //             return true;
    //         }
    //         else
    //         {
    //             return false;
    //         }
    //     }

    //     // Count the number of periods for a reverse pendulum
    //     float CountPeriods()
    //     {
    //         float pendulumPeriod = 0;
    //         int pendulumSwings = 0;

    //         // Count the number of swings within the given time frame
    //         while (pendulumSwings < maxSwings)
    //         {
    //             if (ReversePendulumConditions())
    //             {
    //                 startTime = Time.time;
    //                 pendulumSwings++;
    //             }
    //             else
    //             {
    //                 pendulumPeriod += Time.time - startTime;
    //             }
    //         }

    //         return pendulumPeriod;

    //     }
    //     float totalPeriod = CountPeriods();
    //     // // Calculate the current swing angle of the pendulum
    //     // float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;

    //     // // Increment the period counter every time the pendulum swings past the vertical position
    //     //   if (Mathf.Abs(angle) == 180)
    //     // {
    //     //     swingCount++;
    //     // }

    //     // // Increment the period counter every two swings
    //     // if (swingCount % 2 == 0)
    //     // {
    //     //     period++;
    //     // }
    //     // Debug.Log(swingCount);
    //     Debug.Log(totalPeriod);



        // to jest w Update w razie co 
        // if (Input.GetMouseButtonDown(0))
        // {
        //     // rb.AddForce(Vector2.right * force, ForceMode2D.Impulse);
        // }
