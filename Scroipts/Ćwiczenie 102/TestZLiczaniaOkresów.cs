using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TestZLiczaniaOkresów : MonoBehaviour
{
    // Text mesh to display the current angle of the pendulum
    public TextMeshProUGUI periodText;
    // Transform component of the pivot point of the pendulum
    public Transform pivot;
    // Current period of the pendulum, in seconds
    private float period = 0;

    // Timer component to keep track of the elapsed time
    public Timer timer;

    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    void Update()
    {
        PeriodMathPendulum.GetInstance().SetNewCurrentPosition(pivot.position.x);

        if (PeriodMathPendulum.GetInstance().GetPeriod() == 10)
            {
                timer.stopTimer();
            }
        if (PeriodMathPendulum.GetInstance().GetPeriod() <= 10)
        {
            periodText.text = "" + PeriodMathPendulum.GetInstance().GetPeriod().ToString();
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
