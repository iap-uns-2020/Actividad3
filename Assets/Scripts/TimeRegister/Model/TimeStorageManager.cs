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
			string bestTimeSaved = Get(currentLevel);
			if (string.IsNullOrEmpty(bestTimeSaved))
			{
				Save(currentLevel, currentTime);
			}
			else
			{
				bestTime = TimeSpan.Parse(bestTimeSaved);
				if (currentTime < bestTime)
				{
					Save(currentLevel, currentTime);
				}
			}
		}


		public string Get(int level){
			string timeKey = TIMEKEY+level;
			string levelTime = "";
			if (PlayerPrefs.HasKey(timeKey))
			{
				levelTime = WithoutMillis(PlayerPrefs.GetString(timeKey));
			}
			return levelTime;
		}

		public void Save(int level, TimeSpan timeSpan){
			string timeKey = TIMEKEY+level;
			PlayerPrefs.SetString(timeKey,timeSpan.ToString());
		}

		private string WithoutMillis(string str){
			string output = "";
			int i=0;
			while(i<str.Length && str[i]!='.'){
				output+=str[i];
				i++;
			}
			return output;
		}
	}	
}
