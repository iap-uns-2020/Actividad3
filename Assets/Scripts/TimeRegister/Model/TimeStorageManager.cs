using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TimeRegister.View;
using LevelCreation.Model;

namespace TimeRegister.Model{
	public class TimeStorageManager : ITimeStorageManager{
		private const string TIMEKEY = "times";
		private TimeSpan finnishTime;
		private int currentLevel;
		private ICurrentLevelManager currentLevelManager;
		private ITimerGUI timerGUI;

		public TimeStorageManager()
        {
			currentLevelManager = new CurrentLevelManager();
			currentLevel = currentLevelManager.GetCurrentLevel();

		}

		public void RegisterStartTime()
		{
			TimeSpan startTime = System.DateTime.Now.TimeOfDay;
			PlayerPrefs.SetString("startTime", startTime.ToString());
			Debug.Log(startTime);
		}

		public void RegisterFinnishTime()
		{
			finnishTime = System.DateTime.Now.TimeOfDay;
			CheckIfExceedBestTime();
		}

		public void CheckIfExceedBestTime()
		{
			TimeSpan startTime = TimeSpan.Parse(PlayerPrefs.GetString("startTime"));
			TimeSpan currentTime = finnishTime - startTime;
			TimeSpan bestTime;
			Debug.Log("lalalala :" + Get(1));
			string bestTimeSaved = Get(1);
			Debug.Log("besttimeSaved: " + bestTimeSaved);
			if (string.Compare(bestTimeSaved,"")==0)
			{
				Save(currentLevel, currentTime);
				Debug.Log("save arriba"+Get(1));
				Debug.Log("is null ");
			}
			else
			{
				bestTime = TimeSpan.Parse(bestTimeSaved);
				Debug.Log("best time " + bestTime);
				Debug.Log("currentTime: " + currentTime);
				if (currentTime < bestTime)
				{
					Save(currentLevel, currentTime);
					Debug.Log("entre al chequeo ");
					Debug.Log("save abajo"+Get(1));
				}
			}
		}


		public string Get(int level){
			string timeKey = TIMEKEY+level;
			string levelTime = "";
			if (PlayerPrefs.HasKey(timeKey))
			{
				Debug.Log("entre a has key"+timeKey);
				levelTime = PlayerPrefs.GetString(timeKey);
			}
			else Debug.Log("No entre a has key" + timeKey);
			Debug.Log("time leveel: "+levelTime);
			return levelTime;
		}

		public void Save(int level, TimeSpan timeSpan){
			Debug.Log(level);
			Debug.Log(timeSpan);
			string timeKey = TIMEKEY+level;
			PlayerPrefs.SetString(timeKey,timeSpan.ToString());
			Debug.Log("holaa que tal"+timeSpan.ToString());
			Debug.Log(timeKey);
		}
	}	
}
