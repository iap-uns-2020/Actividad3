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
        private const char PLANECODE = 'p';
        public GameObject plane;
	    public GameObject camera;
	    private ISceneObjectManagerPresenter sceneObjectManagerPresenter;
	    private IBoardManagerPresenter boardManagerPresenter;
	    private ICurrentLevelManagerPresenter currentLevelManagerPresenter;
        private IDictionarySkin dictionarySkin;
        private int currentLevel;

	    void Start(){
	        boardManagerPresenter = new BoardManagerPresenter(this,new BoardManager());
	        currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
	        sceneObjectManagerPresenter = new SceneObjectManagerPresenter();
	        currentLevel = currentLevelManagerPresenter.GetCurrentLevel();
            dictionarySkin = new DictionarySkin();
            StartLevel(currentLevel);    
	    }

	    public void StartLevel(int level){
	        boardManagerPresenter.Load(level);
	        CreateBoard(); 
	    }

	    public void CreateBoard(){
	        int rows = boardManagerPresenter.GetRows();
	        int cols = boardManagerPresenter.GetCols();
	        string levelToPlay = boardManagerPresenter.GetLevelToPlay();

	        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);

	        SceneObjectCreator myPlane = sceneObjectManagerPresenter.GetRawSceneObject(PLANECODE);

            if (dictionarySkin.Exists(currentLevel))
            {
                myPlane.SetTheme(dictionarySkin.GetNameSkin(currentLevel));
            }
	        myPlane.Place(rows/2,cols/2);


	        int k = 0;
	        for (int i = 0; i < rows; i++){
	            for (int j = 0; j < cols; j++){

	            	if(sceneObjectManagerPresenter.Exists(levelToPlay[k])){
	                    SceneObjectCreator currentSceneObject = sceneObjectManagerPresenter.GetRawSceneObject(levelToPlay[k]);
                        if (dictionarySkin.Exists(currentLevel)){
                            currentSceneObject.SetTheme(dictionarySkin.GetNameSkin(currentLevel));
                        }
                        currentSceneObject.Place(i,j);	
                            
	                }
	                    k++;
	            }
	        }
	    }
	}	
} 
