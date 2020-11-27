
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BoardGUI : MonoBehaviour, IBoardGUI
{

    public GameObject plane;
    public GameObject camera;

    private int currentLevel;
    private Vector3 ballPosition;
    private SceneObject ballObject;
    private SceneObjectManager sceneObjectManager;
    private ILevelManagerPresenter levelManagerPresenter;
    private ICurrentLevelManagerPresenter currentLevelManagerPresenter;
    private CollisionsManager collisionsManager;


    void Start(){
        levelManagerPresenter = new LevelManagerPresenter(this,new Level());
        currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
        sceneObjectManager = new SceneObjectManager();
        currentLevel = currentLevelManagerPresenter.GetCurrentLevel();
        StartLevel(currentLevel);
        Debug.Log("boardgui");
    }

    public void StartLevel(int level){
        levelManagerPresenter.Load(level);
        Debug.Log("entre al start level");
        CreateBoard(); 
    }

    public void CreateBoard()
    {
        int rows = levelManagerPresenter.GetRows();
        int cols = levelManagerPresenter.GetCols();
        string levelToPlay = levelManagerPresenter.GetLevelToPlay();

        plane.transform.localScale = new Vector3(rows/10.0f, 1, cols/10.0f);
        plane.transform.position = new Vector3(rows / 2, -1f, cols/2);
        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);


        int k = 0;
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){

            	if(sceneObjectManager.Exists(levelToPlay[k]))
                {
                    SceneObject current = sceneObjectManager.GetRawSceneObject(levelToPlay[k]);
                    current.Place(new Vector3(i, 0, j));
                    if (levelToPlay[k] == 'b')
                    {
                        ballPosition = new Vector3(i, 0, j);
                        ballObject = current;
                        
                    }
                }

                    k++;
            }
        }
    }

    public void Replay()
    {
        ballObject.DestroyBall();
        StartLevel(currentLevel);
    }

}