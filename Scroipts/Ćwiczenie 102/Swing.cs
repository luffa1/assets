using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public Rigidbody2D rb;

    void Update()
    {
        rb.AddForce(Vector2.right * Mathf.Sin(Time.time), ForceMode2D.Impulse);
    }
}
