using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevelManagerPresenter : ICurrentLevelManagerPresenter{
	private ICurrentLevelManager currentLevelManager;
	public CurrentLevelManagerPresenter(){
		currentLevelManager = new CurrentLevelManager();
	}
    public void SetCurrentLevel(int level){
        currentLevelManager.SetCurrentLevel(level);
    }

    public int GetCurrentLevel(){
        return currentLevelManager.GetCurrentLevel();
    }
}
