using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using LevelCreation.Presenter;
using BoardCreation.View;
using TimeRegister.Presenter;

namespace GameResult.View{
	public class GameResultManager : MonoBehaviour, IGameResultManger{
		private const string WINSCENE = "WinScene";
		private const int MAINPANELSCENE = 0;
		private const int GAMESCENE = 1;
		private ICurrentLevelManagerPresenter currentLevelManagerPresenter;
		private ITimeStorageManagerPresenter timeStorageManagerPresenter;
		private IBoardGUI boardGUI; 
		private string activeScene;
		public GameObject IBoardGUI;

		void Start(){
			timeStorageManagerPresenter = new TimeStorageManagerPresenter();
			currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
			boardGUI = IBoardGUI.GetComponent<IBoardGUI>();
			GetSceneName();
			RegisterFinnishTimeIfMust();
		}

		public void MenuButtonListener(){
			SceneManager.LoadScene(MAINPANELSCENE);
		}

		public void ReplayButtonListener(){
			timeStorageManagerPresenter.RegisterStartTime();
			SceneManager.LoadScene(GAMESCENE);
		}

		public void NextLevelButtonListener(){
			int currentLevel = currentLevelManagerPresenter.GetCurrentLevel();
			int nextLevel = currentLevel+1;
			boardGUI.StartLevel(nextLevel);
			currentLevelManagerPresenter.SetCurrentLevel(nextLevel);
			SceneManager.LoadScene(GAMESCENE);
		}

		private void GetSceneName(){
			activeScene = SceneManager.GetActiveScene().name;
		}

		private void RegisterFinnishTimeIfMust(){
			if(string.Compare(activeScene, WINSCENE)==0)
				timeStorageManagerPresenter.RegisterFinnishTime();
		}
	}	
}

