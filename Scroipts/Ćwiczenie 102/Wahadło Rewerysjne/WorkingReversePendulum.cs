using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class WorkingReversePendulum : MonoBehaviour
{
    // Text mesh to display the current angle of the pendulum
    public TextMeshProUGUI periodText;

    // Transform component of the pivot point of the pendulum
    public Transform pivot;

    // Current angle of the pendulum
    private float curAngle;

    // Previous angle of the pendulum
    private float previousAngle = 0;

    // Time of the last change in the direction of the pendulum
    private float lastChangeTime = 0;

    // Current period of the pendulum, in seconds
    private float period = 0;

    // Number of periods to measure
    public int numPeriods = 10;

    // Number of times the pendulum has changed direction
    private int directionChanges = 0;

    // Whether the pendulum is currently swinging in the same direction
    private bool sameDirection = false;

    // Timer component to keep track of the elapsed time
    public Timer timer;

    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    void Update()
    {
        // Calculate the current angle of the pendulum
        curAngle = Mathf.Atan2(pivot.up.y, pivot.up.x) * Mathf.Rad2Deg;

        // Ensure that the angle is within the range 0 to 90 degrees
        curAngle = Mathf.Abs(curAngle) % 45;

        // Update the text display with the current angle

       // Check if the pendulum has changed direction
        if (curAngle > previousAngle && !sameDirection)
        {
            // Pendulum is swinging in the same direction as before
            sameDirection = true;

            // Update the time of the last change in direction
            lastChangeTime = timer.ElapsedTime;

            // Increment the number of direction changes
            directionChanges++;

            // Check if the number of direction changes has reached 4 (one full period)
            if (directionChanges == 2)
            {
                // Reset the number of direction changes
                directionChanges = 0;

                // Increment the period
                period++;

                // Check if the desired number of periods has been reached
                if (period >= numPeriods)
                {
                    // Stop the timer
                    timer.stopTimer();
                    return;
                }
            }
        
        }
        else if (curAngle < previousAngle && sameDirection)
        {
            // Pendulum has changed direction
            sameDirection = false;
        }
        // Update the previous angle
        previousAngle = curAngle;

            // Update the text display with the current period
            if (period < numPeriods)
            {
                periodText.text = "" + period.ToString();
            }
            else
            {
                periodText.text = "10";
            }
    }
     void OnMouseDrag() 
    {

		Vector3 Screepoint = Camera.main.WorldToScreenPoint (transform.position);
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Screepoint.z);
		Vector3 objposition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = objposition;
        transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
    }
    void OnMouseUp() {

        timer.startTimer();
		period = 0;	
    }
}
