using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReversePendulum : MonoBehaviour
{
    public TextMeshProUGUI text; // Display the current angle
    public Transform pivot; // Pivot point for the pendulum
    public TextMeshProUGUI textt; // Display the period
    private bool ad = false;
    private int period = 0; // Period of the pendulum
	private float previousPivotY = 0;
	private int counter = 0;
    private bool increasing = false;
    private bool previousIncreasing = false;
    public Timer timer; // Timer object
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

        void Update()
    {
        // Check if the pivot point's position has changed
        if (pivot.position.y != previousPivotY)
        {
            // If the pivot point's position has changed, update the previous position
            previousPivotY = pivot.position.y;

            // Determine whether the pivot point's position is increasing or decreasing
            if (previousIncreasing == false && pivot.position.y > previousPivotY)
            {
                increasing = true;
            }
            else if (previousIncreasing == true && pivot.position.y < previousPivotY)
            {
                increasing = false;
            }

            // If the direction of the pivot point's movement has changed, increment the counter
            if (increasing != previousIncreasing)
            {
                previousIncreasing = increasing;
                counter += 1;
            }

            // If the counter reaches 4, increment the period and reset the counter
            if (counter == 4)
            {
                counter = 0;
                period += 1;
                if (period >= 10)
                {
                    timer.stopTimer();
                }
            }

            textt.text = "" + period.ToString();
			// Debug.Log(counter);
        }
    }
    void OnMouseDrag() {

		Vector3 Screepoint = Camera.main.WorldToScreenPoint (transform.position);
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Screepoint.z);
		Vector3 objposition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = objposition;
        transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
    }

    void OnMouseUp() {

        timer.startTimer();
		ad = false;
		period = 0;
		counter = 0;	
    }

}
