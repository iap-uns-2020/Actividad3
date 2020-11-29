using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using BoardCreation.Presenter;
using BoardCreation.Model;
using LevelCreation.Presenter;
using LevelCreation.Model;
using SkinManager;

namespace BoardCreation.View{
	public class BoardGUI : MonoBehaviour, IBoardGUI{
	    public GameObject plane;
	    public GameObject camera;
	    private ISceneObjectManagerPresenter sceneObjectManagerPresenter;
	    private ILevelManagerPresenter levelManagerPresenter;
	    private ICurrentLevelManagerPresenter currentLevelManagerPresenter;
        private IDictionarySkin dictionarySkin;
        private int currentLevel;

	    void Start(){
	        levelManagerPresenter = new LevelManagerPresenter(this,new Level());
	        currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
	        sceneObjectManagerPresenter = new SceneObjectManagerPresenter();
	        currentLevel = currentLevelManagerPresenter.GetCurrentLevel();
            dictionarySkin = new DictionarySkin();
            StartLevel(currentLevel);    
	    }

	    public void StartLevel(int level){
	        levelManagerPresenter.Load(level);
	        CreateBoard(); 
	    }

	    public void CreateBoard(){
	        int rows = levelManagerPresenter.GetRows();
	        int cols = levelManagerPresenter.GetCols();
	        string levelToPlay = levelManagerPresenter.GetLevelToPlay();

	        //plane.transform.localScale = new Vector3(rows/10.0f, 1, cols/10.0f);
	        plane.transform.position = new Vector3(rows / 2, -1f, cols/2);
	        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);


	        int k = 0;
	        for (int i = 0; i < rows; i++){
	            for (int j = 0; j < cols; j++){

	            	if(sceneObjectManagerPresenter.Exists(levelToPlay[k])){
	                    SceneObject current = sceneObjectManagerPresenter.GetRawSceneObject(levelToPlay[k]);
                        if (dictionarySkin.Exists(currentLevel))
                        {
                            current.SetTheme(dictionarySkin.GetNameSkin(currentLevel));
                        }
                        current.Place(new Vector3(i, 0, j));      
	                }
	                    k++;
	            }
	        }
	    }
	}	
} 
