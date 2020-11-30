using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStorage.Model{
	public class LevelStorageManager : ILevelStorageManager{
		private const string LEVELSKEY = "levels";
		private const string LEVELCOUNTKEY = "quantity";
		private const string FIRSTLEVEL = "11#12#wwwwwwwwwwwwwffffffffffwwfwffwwwwwfwwfwfwffhwwfwwfwwwwffwhfwwffffwgfhffwwfwwfwfffffwwfwffffhfffwwfwfhffffffwwbfffffffffwwwwwwwwwwwww";
		private const string SECONDLEVEL = "10#8#wwwwwwwwwfffhhhwwfhfffgwwfwwwhhwwfffhhhwwfhffffwwhfhhffwwwwwwffwwbfffffwwwwwwwww";
		private const string THIRDLEVEL = "14#8#wwwwwwwwwffffffwwfffhwfwwffhfwfwwfhffwfwwffwwwfwwhfwfffwwffwfhfwwfwwwffwwfwgwfhwwfffwffwwwwwwhfwwbfffffwwwwwwwww";

		public void Save(string upcomingLevel){
			int levelCount = PlayerPrefs.GetInt(LEVELCOUNTKEY);
			PlayerPrefs.SetString(LEVELSKEY + "" + (levelCount + 1), upcomingLevel);
			levelCount++;
			PlayerPrefs.SetInt(LEVELCOUNTKEY, levelCount);
		}


		public string Get(int level){
			return PlayerPrefs.GetString(LEVELSKEY + "" + level);
		}

		public int LevelCounter(){
			return PlayerPrefs.GetInt(LEVELCOUNTKEY);
		}

		public void Preload(){
			if(LevelCounter() == 0){
				Save(FIRSTLEVEL);
				Save(SECONDLEVEL);
				Save(THIRDLEVEL);
			}
		}
	}
}