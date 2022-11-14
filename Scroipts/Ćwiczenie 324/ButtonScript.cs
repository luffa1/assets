using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    public Button shift;
    bool shifted;
    void Start()
    {
        // amperGaugeScript =GameObject.FindGameObjectWithTag("Amperomierz").GetComponent<AmperGauge>();
        // Button amperGaugeScrip = GetComponent<Button>();
        shift.onClick.AddListener(ShiftClicked);
    }
 
    void Update()
    {
        // amperGaugeScript.Polarization0();

    }
    public void ShiftClicked()
    {
        shifted = !shifted;
        if (shifted)
        {
         buttonText.text = "0";
        }
        else
         buttonText.text = "90";
    }
}
