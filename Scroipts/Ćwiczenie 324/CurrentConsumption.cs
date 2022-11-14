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
        // funkcja, która powinna jedynie odczytywać tylko zadeklarowane liczby
        // float previousValue = 0;
        // if (previousValue == n)
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
        if (n == 20)
        {
            transform.position = new Vector2(-5.12f, 2.94f);
        }
        if (n == 25)
        {
            transform.position = new Vector2(-4.64f, 3.31f);
        }
        if (n == 30)
        {
            transform.position = new Vector2(-4.32f, 3.3f);
        }
        if (n == 35)
        {
            transform.position = new Vector2(-3.2f, 3.3f);
        }
        if (n == 40)
        {
            transform.position = new Vector2(-2.88f, 3.73f);
        }
        if (n == 45)
        {
            transform.position = new Vector2(-2.4f, 3.41f);
        }
        if (n == 50)
        {
            transform.position = new Vector2(-1.49f, 3.68f);
        }
        if (n == 55)
        {
            transform.position = new Vector2(-0.96f, 3.68f);
        }
        if (n == 60)
        {
            transform.position = new Vector2(-0.64f, 3.68f);
        }
        if (n == 65)
        {
            transform.position = new Vector2(-0.26f, 3.7f);
        }
        if (n == 70)
        {
            transform.position = new Vector2(0f, 3.98f);
        }
        if (n == 75)
        {
            transform.position = new Vector2(0.22f, 3.99f);
        }
        if (n == 80)
        {
            transform.position = new Vector2(0.43f, 4f);
        }
        if (n == 85)
        {
            transform.position = new Vector2(0.7f, 4.01f);
        }
        if (n == 90)
        {
            transform.position = new Vector2(-5.2f, 0.4f);
        }
        if (n == 95)
        {
            transform.position = new Vector2(-5.2f, 0.4f);
        }
        if (n == 100)
        {
            transform.position = new Vector2(-5.2f, 0.4f);
        }
    }
}
