using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public string timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;
    void Update()
    {
        UpdateTimerUI();
    }
    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        timerText = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }
}
