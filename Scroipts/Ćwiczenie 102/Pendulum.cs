using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pendulum : MonoBehaviour
{
    Rigidbody2D rb2d;
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
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }
    // Update is called once per frame
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

		Vector2 Screepoint = Camera.main.WorldToScreenPoint (transform.position);
        Vector2 mouseposition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		Vector2 objposition = Camera.main.ScreenToWorldPoint (mouseposition);
		transform.position = objposition;
        transform.position = new Vector2 (transform.position.x, transform.position.y);
    }

    void OnMouseUp() {

        timer.startTimer();
		ad = false;
		period = 0;
		counter = 0;	
    }

}
