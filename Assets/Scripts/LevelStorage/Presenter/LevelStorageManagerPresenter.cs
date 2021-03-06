using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LevelStorage.Model;

namespace LevelStorage.Presenter
{
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

        public void Save(string upcomingLevel)
        {
            levelStorageManager.Save(upcomingLevel);
        }

        public string Get(int level)
        {
            return levelStorageManager.Get(level);
        }

        public void Preload(){
            levelStorageManager.Preload();
        }
    }
}