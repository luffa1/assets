using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightMovemenet : MonoBehaviour
{
    void OnMouseDrag()
    {
        Vector3 Screenpoint = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Screenpoint.z);
        Vector3 ObjPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = ObjPosition;
        transform.position = new Vector3(0, transform.position.y, 0);
    }
    
}
