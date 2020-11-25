using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStorageManagerPresenter : ILevelStorageManagerPresenter
{
    private ILevelStorageManager levelStorageManager;

    public LevelStorageManagerPresenter()
    {
        levelStorageManager = new LevelStorageManager();
    }

    public int LevelCounter()
    {
        return levelStorageManager.LevelCounter();
    }

    public void Save(string upcomingLevel){
        Debug.Log("Llego aca, presenter");
    	levelStorageManager.Save(upcomingLevel);
    }

    public string Get(int level){
        return levelStorageManager.Get(level);
    }

    public void SetCurrentLevel(int level){
        levelStorageManager.SetCurrentLevel(level);
    }

    public int GetCurrentLevel(){
        return levelStorageManager.GetCurrentLevel();
    }
}