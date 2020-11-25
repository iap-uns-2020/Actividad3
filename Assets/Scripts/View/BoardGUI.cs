
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


    void Start()
    {

        levelManagerPresenter = new LevelManagerPresenter(this,new Level());
        sceneObjectManager = new SceneObjectManager();
        levelManagerPresenter.Load(1);
        CreateBoard();

    }

    public void Initiate(int levelNumber){

    }

    public void CreateBoard()
    {
        int rows = levelManagerPresenter.GetRows();
        int cols = levelManagerPresenter.GetCols();
        string levelToPlay = levelManagerPresenter.GetLevelToPlay();


        plane.transform.localScale = new Vector3(rows/10, 1, cols/10);
        plane.transform.position = new Vector3(rows / 2, 0, cols/2);
        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);

        int k = 0;
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){

            	if(levelToPlay[k]!='f'){
            		SceneObject current = sceneObjectManager.GetRawSceneObject(levelToPlay[k]);
               	 	current.Place(new Vector3(i,0,j));	
            	}

                k++;
            }
        }
    }
}