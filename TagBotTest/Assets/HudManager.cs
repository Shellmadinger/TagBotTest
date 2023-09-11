using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class HudManager : MonoBehaviour
{
    public Text tagText;
    public bool uiBool = true;

    // Update is called once per frame
    void Update()
    {
        UpdateHud();
    }

    void UpdateHud()
    {
        if (uiBool == true)
        {
            tagText.text = "You are Tagged";
        }

        else{
            tagText.text = "You are not Tagged";
        }
    }
}
