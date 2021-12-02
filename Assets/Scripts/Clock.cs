using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot = default, minutesPivot, secondsPivot;

    const float hoursToDegrees = -30, minutesToDegrees = -6, secondsToDegrees = -6;

    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        //Debug.Log(DateTime.Now.Hour);
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
      secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)time.TotalSeconds);
    }

}
