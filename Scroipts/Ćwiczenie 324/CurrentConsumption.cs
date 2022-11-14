using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CurrentConsumption : MonoBehaviour
{
    [SerializeField] private Slider gaugePosition;
    void Start()
    {
        gaugePosition.onValueChanged.AddListener(delegate {
        });
    }

    public void UpdatePosition(double n)
    {
        
        if (n == 1)
        {
            transform.position = new Vector2(-7.44f, 0.83f);
        }
        if (n == 2)
        {
            transform.position = new Vector2(-6.57f, 2.03f);
        }
        if (n == 3)
        {
            transform.position = new Vector2(-5.98f, 2.67f);
        }
        if (n == 4)
        {
            transform.position = new Vector2(-5.12f, 2.94f);
        }
        if (n == 5)
        {
            transform.position = new Vector2(-3.19f, 4.41f);
        }
        if (n == 6)
        {
            transform.position = new Vector2(-4.32f, 3.3f);
        }
        if (n == 7)
        {
            transform.position = new Vector2(-3.2f, 3.3f);
        }
        if (n == 8)
        {
            transform.position = new Vector2(-2.88f, 3.73f);
        }
        if (n == 9)
        {
            transform.position = new Vector2(-2.4f, 3.41f);
        }
        if (n == 10)
        {
            transform.position = new Vector2(-1.49f, 3.68f);
        }
        if (n == 11)
        {
            transform.position = new Vector2(-0.96f, 3.68f);
        }
        if (n == 12)
        {
            transform.position = new Vector2(-0.64f, 3.68f);
        }
        if (n == 13)
        {
            transform.position = new Vector2(-0.26f, 3.7f);
        }
        if (n == 14)
        {
            transform.position = new Vector2(0f, 3.98f);
        }
        if (n == 15)
        {
            transform.position = new Vector2(0.22f, 3.99f);
        }
        if (n == 16)
        {
            transform.position = new Vector2(0.43f, 4f);
        }
        if (n == 17)
        {
            transform.position = new Vector2(0.7f, 4.01f);
        }
    }
}
