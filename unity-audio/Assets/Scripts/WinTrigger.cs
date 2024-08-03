using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinTrigger : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public int increasedFontSize = 60;
    public Color winColor = Color.green;

    public GameObject winCanvas;
    public TextMeshProUGUI finalTimeText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Timer playerTimer = other.GetComponent<Timer>();
            if (playerTimer != null)
            {
                playerTimer.StopTimer();
                timerText.fontSize = increasedFontSize;
                timerText.color = winColor;

                // Call the Win method on the Timer script to handle win logic
                playerTimer.Win(finalTimeText);
                Debug.Log("Player won - final time: " + finalTimeText.text);

                // Activate the WinCanvas
                winCanvas.SetActive(true);
            }
        }
    }
}
