using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleTimer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;

    void Start()
    {
        if (TimerText != null)
        {
            TimerText.text = "0:00.00";
        }
    }
}