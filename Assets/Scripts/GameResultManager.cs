using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using LevelCreation.Presenter;
using BoardCreation.View;

public class GameResultManager : MonoBehaviour{
	private const int MAINPANELSCENE = 0;
	private const int GAMESCENE = 1;
	private ICurrentLevelManagerPresenter currentLevelManagerPresenter;
	public GameObject IBoardGUI;
	private IBoardGUI boardGUI; 

	void Start(){
		currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
		boardGUI = IBoardGUI.GetComponent<IBoardGUI>();
	}

	public void MenuButtonListener(){
		SceneManager.LoadScene(MAINPANELSCENE);
	}

	public void ReplayButtonListener(){
		SceneManager.LoadScene(GAMESCENE);
	}

	public void NextLevelButtonListener(){
		int currentLevel = currentLevelManagerPresenter.GetCurrentLevel();
		int nextLevel = currentLevel+1;
		boardGUI.StartLevel(nextLevel);
		currentLevelManagerPresenter.SetCurrentLevel(nextLevel);
		SceneManager.LoadScene(GAMESCENE);
	}
}
