using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMovementOpenAi : MonoBehaviour
{
    // parametry wahadła
    public float mass = 1.0f;    // masa ciała wahadła [kg]
    public float length = 1.0f;  // długość sprężyny [m]
    public float k = 1.0f;       // stała Hooke'a sprężyny [N/m]
    public float gravity = 9.81f; // stała grawitacji [m/s^2]
    public float length0;

    // pozycja i prędkość wahadła
    private float angle = 1.0f;   // kąt odchylenia od pozycji równowagi [rad]
    private float angularVelocity = 1.0f; // prędkość kątowa [rad/s]

    // czas
    private float timeStep = 0.01f; // krok czasowy [s]
    

    void Update()
    {
        // obliczenie siły i przyspieszenia wahadła
        float force = -mass * gravity * Mathf.Sin(angle) - k/mass * (length - length0) * angle;
        float acceleration = force / mass;

        // aktualizacja pozycji i prędkości wahadła
        angle += angularVelocity * timeStep;
        angularVelocity += acceleration * timeStep;

        // aktualizacja położenia ciała wahadła w scenie
        transform.position = new Vector2(length * Mathf.Sin(angle), -length * Mathf.Cos(angle));
    }
}

