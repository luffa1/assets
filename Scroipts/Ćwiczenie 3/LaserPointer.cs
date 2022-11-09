using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;

    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }


    void Update()
    {
        
    }
}
