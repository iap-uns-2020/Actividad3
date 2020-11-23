using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStorageManager : ILevelStorageManager{
	private const string LEVELSKEY = "levels";
	private const string LEVELCOUNTKEY = "quantity";
	
	public void Save(string upcomingLevel){
		Debug.Log("llego acaaaaaaaaaaaaa!");
		Debug.Log("upcomingLevel: "+upcomingLevel);
		int levelCount = PlayerPrefs.GetInt(LEVELCOUNTKEY);
		PlayerPrefs.SetString(LEVELSKEY+""+(levelCount+1),upcomingLevel);
		levelCount++;
		PlayerPrefs.SetInt(LEVELCOUNTKEY,levelCount);
	}

	public string Get(int level){

		Debug.Log(LEVELSKEY+""+(PlayerPrefs.GetInt(LEVELCOUNTKEY)+1));
		return PlayerPrefs.GetString(LEVELSKEY+""+level);
	}

	public int LevelCounter(){
		return PlayerPrefs.GetInt(LEVELCOUNTKEY);
	}
}