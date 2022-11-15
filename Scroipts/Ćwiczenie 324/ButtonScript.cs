using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public GameObject Amperomierz;
    public TextMeshProUGUI buttonText;
    bool shifted;
    void Start()
    {
        
        // amperGaugeScript =GameObject.FindGameObjectWithTag("Amperomierz").GetComponent<AmperGauge>();
        // Button amperGaugeScrip = GetComponent<Button>();
    }
 
    void Update()
    {
        // amperGaugeScript.Polarization0();

    }
    public void ShiftClicked()
    {
        Amperomierz.SetActive(true);
         shifted = !shifted;
        if (shifted)
        {
         buttonText.text = "0";
        }
        else
         buttonText.text = "90";
    }
}
