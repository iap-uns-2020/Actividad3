using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStorageManager : ILevelStorageManager{
	private const string LEVELSKEY = "levels";
	private const string LEVELCOUNTKEY = "quantity";
	
	public void Save(string newLevel){
		int levelCount = PlayerPrefs.GetInt(LEVELCOUNTKEY);
		PlayerPrefs.SetString(LEVELSKEY+(levelCount+1),newLevel);
		levelCount++;
		PlayerPrefs.SetInt(LEVELCOUNTKEY,levelCount);
	}

	public string Get(int level){
		return PlayerPrefs.GetString(LEVELSKEY+level);
	}

	public int LevelCounter(){
		return PlayerPrefs.GetInt("quantity");
	}
}