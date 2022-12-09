using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pendulum : MonoBehaviour
{
    
    float distance = 0;

	public TextMeshProUGUI text;

	public Transform pivot;

	private float curangle;

	public TextMeshProUGUI textt;

	private bool ad = false;
	public int period = 0;
	private float previousangle = 0;
	// private bool pom;
	private float testangle;
	private int counter = 0;
	private bool rosnie = false;
	private bool wczesniejsze = false;
    public Timer timer;
    void Start()
    {
		Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    void Update()
    {
        testangle = previousangle;
	    previousangle = curangle;

        
			CalculateAngle();

			if (previousangle == curangle)
			{
				previousangle = testangle;
			}

			if (previousangle < curangle)
			{
				text.text = "rośnie : " + previousangle.ToString("f1");
				
				if (rosnie == false)
				{
					rosnie = true;
					counter += 1;
				}
				
			}
			else 
			{
				text.text = "maleje : " + curangle.ToString("f1");
				
				if (rosnie == true)
				{
					rosnie = false;
					counter += 1;
				}
			}
			if (counter == 4)
			{
				counter = 0;
				period += 1;
				if(period >= 10) {
					timer.stopTimer();
				}
			}
			
			textt.text = "" + period.ToString();
	} 

	void CalculateAngle ()
	{
		if (curangle > 90 && curangle < 180)
		{
			curangle = 90 - curangle;
				
		} 
		else if (curangle > 180 && curangle < 270) 
		{
			curangle = 180 - curangle;	
		} 
		else if (curangle > 270 && curangle <= 360) 
		{
			curangle = 360 - curangle;	
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
