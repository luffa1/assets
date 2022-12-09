using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deviation : MonoBehaviour
{
    public InputField X;
    public Transform circle;

    public void AcceptButton()
    {
        Vector3 temp = new Vector3();
        string x = "0";
        string y = "0";
        if (X.text == "1") 
        {
            x = "9,7";
            y = "6,1";
        } else if (X.text == "2")
        {
            x = "6";
            y = "2";
        }
        temp.x = Convert.ToSingle(x);
        temp.y = Convert.ToSingle(y);
        circle.position = temp;
    }


}
