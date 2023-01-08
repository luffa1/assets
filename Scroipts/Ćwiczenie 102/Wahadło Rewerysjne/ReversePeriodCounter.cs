using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReversePeriodCounter : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public TextMeshProUGUI periodText;
    private float previousSpeed = 0;
    private int halfPeriod = 0;
    private int period{get => halfPeriod/2;}
    public ReversePendulumTimer timerr;

    void Start()
    {
        timerr = GameObject.Find("ReversePendulumTimer").GetComponent<ReversePendulumTimer>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float speed = rb2D.velocity.x;
        if (previousSpeed * speed < 0)
        {
            halfPeriod ++;
        }
        if (period >= 10)
        {
            timerr.stopTimer();
        }
        if (period <= 10)
        {
            periodText.text = period.ToString("");
        }
        previousSpeed = speed;
    }
}
