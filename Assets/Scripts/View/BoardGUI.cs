
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardGUI : MonoBehaviour
{

    public GameObject plane;
    public GameObject camera;

    public SceneObjectManager sceneObjectManager;
    private ILevelManagerPresenter levelManagerPresenter;

    void Start()
    {

        levelManagerPresenter = new LevelManagerPresenter(this,new Level(1));
        CreateBoard();

    }

    public void Initiate(int levelNumber){

    }

    public void CreateBoard()
    {
        int rows = levelManagerPresenter.GetRows();
        int cols = levelManagerPresenter.GetCols();
        string levelToPlay = levelManagerPresenter.GetLevelToPlay();

        plane.transform.localScale = new Vector3(rows/5, 1, cols/5);
        plane.transform.position = new Vector3(rows / 2, 0, cols/2);
        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);

        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Vector3 objectPosition = new Vector3(i, 0, j);
                sceneObjectManager.Create(levelToPlay[k],objectPosition);
                k++;
            }
        }
    }
}