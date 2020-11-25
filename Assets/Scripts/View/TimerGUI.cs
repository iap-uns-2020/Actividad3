using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class TimerGUI : MonoBehaviour{	
    private DateTime startTime;
    private DateTime finnishTime;
    private int currentLevel;
    private ITimeStorageManagerPresenter timeStorageManagerPresenter;
    public Text levelInfo;
    public Text textTime;

    public void RegisterStartTime()
    {
    	timeStorageManagerPresenter = new TimeStorageManagerPresenter();
        startTime = System.DateTime.Now;
    }

    public void RegisterFinnishTime()
    {
        finnishTime = System.DateTime.Now;
    }

    public void ShowTimeSpendInLevel()
    {
        TimeSpan duration = startTime - finnishTime;
        timeStorageManagerPresenter.Save(currentLevel,duration);
        textTime.text = duration.ToString();
    }
    
    public void SetLevel(int level){
    	currentLevel = level;
    }

}