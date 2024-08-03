using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public float time = 0f;
    private bool timerRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Timer Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            time += Time.deltaTime;
            TimerText.text = time.ToString("0:00.00");
            Debug.Log("Timer Update - time: " + time);
        }
    }

    public void StartTimer()
    {
        timerRunning = true;
        Debug.Log("Timer started");
    }

    public void StopTimer()
    {
        timerRunning = false;
        Debug.Log("Timer stopped");
    }

    public void Win(TextMeshProUGUI finalTimeText)
    {
        StopTimer();
        finalTimeText.text = TimerText.text;
        Debug.Log("Timer win - final time: " + TimerText.text);
    }
}
