using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TimeRegister.Model{
	public class TimeStorageManager : ITimeStorageManager{
		private const string TIMEKEY = "times";

		public string Get(int level){
			string timeKey = TIMEKEY+level;
			return PlayerPrefs.GetString(timeKey);
		}

		public void Save(int level, TimeSpan timeSpan){
			string timeKey = TIMEKEY+level;
			PlayerPrefs.SetString(timeKey,timeSpan.ToString());
		}
	}	
}
