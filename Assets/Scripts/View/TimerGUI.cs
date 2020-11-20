using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class NewBehaviourScript : MonoBehaviour
{
    private DateTime startTime;
    private DateTime finnishTime;
    public Text textTime;

    public void RegisterStartTime()
    {
        startTime = System.DateTime.Now;
    }

    public void RegisterFinnishTime()
    {
        finnishTime = System.DateTime.Now;
    }

    public void ShowTimeSpendInLevel()
    {
        TimeSpan duration = startTime - finnishTime;
        textTime.text = duration.ToString();
    }

}