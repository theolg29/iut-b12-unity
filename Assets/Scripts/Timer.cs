using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        int minutes = (int)t / 60;
        int seconds = (int)t % 60;
        timerText.text = string.Format("{0}:{1:00}", minutes, seconds);
    }
}
