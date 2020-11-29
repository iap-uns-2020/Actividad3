using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TimeRegister.View;
using LevelStorage.Presenter;
using LevelCreation.Presenter;

namespace LevelCreation.View
{
    public class LevelSelection : MonoBehaviour, ILevelSelection
    {
        public TimerGUI timerGUI;
        public Button leftArrow;
        public Button rightArrow;
        public Button buttonLevel;
        public Text levelCounterText;
        private int currentLevel;
        private int cantNiveles;
        private ILevelStorageManagerPresenter storageManagerPresenter;
        private ICurrentLevelManagerPresenter currentLevelManagerPresenter;

        void Start()
        {
            storageManagerPresenter = new LevelStorageManagerPresenter();
            UpdateLevelCounter();
            currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
        }

        public void SelectNextLevel()
        {
            if (currentLevel < cantNiveles)
            {
                currentLevel++;
                levelCounterText.text = "Level " + currentLevel;
                timerGUI.ShowTimeSpendInLevel(currentLevel);
            }
        }

        public void SelectPreviousLevel()
        {
            if (currentLevel > 1)
            {
                currentLevel--;
                levelCounterText.text = "Level " + currentLevel;
                timerGUI.ShowTimeSpendInLevel(currentLevel);
            }
        }

        public void SelectFirstLevel()
        {
            if (cantNiveles > 0)
            {
                currentLevel = 1;
                levelCounterText.text = "Level " + currentLevel;
            }
        }

        public void UpdateLevelCounter(){
          cantNiveles = storageManagerPresenter.LevelCounter();  
        }

        private void ChangeScene()
        {
            SceneManager.LoadScene(1);
        }


        private void SetSelectedLevel()
        {
            currentLevelManagerPresenter.SetCurrentLevel(currentLevel);
        }
    }
}

