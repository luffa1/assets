using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationToward : MonoBehaviour
{
    public GameObject square;
    public float speed;
    public float rotationModifier;
    
    // void Start()
    // {
    //     rb2d = GetComponent<Rigidbody2D>();
    // }

    private void FixedUpdate() 
    {
        if (square != null)
        {
            Vector3 vectorToTarget = square.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        }    
    }

}
