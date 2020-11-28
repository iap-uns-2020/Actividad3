using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LevelCreation.Model;

namespace LevelCreation.Presenter
{
    public class CurrentLevelManagerPresenter : ICurrentLevelManagerPresenter
    {
        private ICurrentLevelManager currentLevelManager;
        public CurrentLevelManagerPresenter()
        {
            currentLevelManager = new CurrentLevelManager();
        }
        public void SetCurrentLevel(int level)
        {
            currentLevelManager.SetCurrentLevel(level);
        }

        public int GetCurrentLevel()
        {
            return currentLevelManager.GetCurrentLevel();
        }
    }
}
