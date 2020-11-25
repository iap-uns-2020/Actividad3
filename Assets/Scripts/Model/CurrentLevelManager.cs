using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevelManager : ICurrentLevelManager{
	private const string CURRENTLEVELKEY = "currentLevel";
	
	public void SetCurrentLevel(int level){
		PlayerPrefs.SetInt(CURRENTLEVELKEY,level);	
	}

	public int GetCurrentLevel(){
		return PlayerPrefs.GetInt(CURRENTLEVELKEY);
	}
}
