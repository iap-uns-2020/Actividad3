
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardGUI : MonoBehaviour
{

    public GameObject plane;
    public GameObject camera;

    private SceneObjectManager sceneObjectManager;
    private ILevelManagerPresenter levelManagerPresenter;
    private ICurrentLevelManagerPresenter currentLevelManagerPresenter;
    private CollisionsManager collisionsManager;


    void Start(){
        levelManagerPresenter = new LevelManagerPresenter(this,new Level());
        currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
        collisionsManager = new CollisionsManager();
        sceneObjectManager = new SceneObjectManager();
        StartLevel(currentLevelManagerPresenter.GetCurrentLevel());
    }

    public void StartLevel(int level){
        levelManagerPresenter.Load(level);
        CreateBoard(); 
    }

    public void CreateBoard()
    {
        int rows = levelManagerPresenter.GetRows();
        int cols = levelManagerPresenter.GetCols();
        string levelToPlay = levelManagerPresenter.GetLevelToPlay();

        plane.transform.localScale = new Vector3(rows/10, 1, cols/10);
        plane.transform.position = new Vector3(rows / 2, -1f, cols/2);
        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);

        collisionsManager.setSizeOfMap(rows, cols);

        int k = 0;
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){

            	if(sceneObjectManager.Exists(levelToPlay[k])){
            		SceneObject current = sceneObjectManager.GetRawSceneObject(levelToPlay[k]);
                    collisionsManager.SetObjectPosition(levelToPlay[k], i, j);
                    if (levelToPlay[k]=='b')
                    current.Place(new Vector3(i,1,j));  
                    else
               	 	current.Place(new Vector3(i,0,j));	
            	}

                k++;
            }
        }
    }
}