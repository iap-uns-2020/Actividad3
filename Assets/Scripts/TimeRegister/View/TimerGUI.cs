using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using TimeRegister.Presenter;

namespace TimeRegister.View{
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

	    public void CheckIfExceedBestTime()
	    {
	        TimeSpan currentTime = startTime - finnishTime;
	        string bestTimeSaved = timeStorageManagerPresenter.Get(currentLevel);
	        TimeSpan bestTime = TimeSpan.Parse(bestTimeSaved);
	        if (bestTime < currentTime)
	        {
	            timeStorageManagerPresenter.Save(currentLevel, currentTime);
	            ShowTimeSpendInLevel(currentTime);
	        }
	    }

	    public void ShowTimeSpendInLevel(TimeSpan currentTime)
	    {
	        textTime.text = currentTime.ToString();
	    }
	    
	    public void SetLevel(int level)
	    {
	    	currentLevel = level;
	    }

	}	
}
