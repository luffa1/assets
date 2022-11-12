using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMirror : MonoBehaviour
{
    public float position = 0;
    void Update()
    {
        transform.Rotate(0,0,0);
    }

    public void ObjRotation (float newPosition){
        position = newPosition;
    }
}
