
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardGUI : MonoBehaviour
{

    public GameObject plane;
    public GameObject camera;

    const float POSITIONX = 0f;
    const float POSITIONY = 0f;
    const float POSITIONZ = 0f;

    const float boardSizex = 10f;//*1.067781f;
    const float boardSizey = 10f;//*2.168959f;

    public SceneObjectManager sceneObjectManager;
    private ILevelManagerPresenter levelManagerPresenter;

    void Start()
    {
        //levelManagerPresenter = new LevelManagerPresenter(this,new Level(1));
        CreateBoard();

    }

    public void CreateBoard()
    {
        int rows;// = levelManagerPresenter.GetRows();
        int cols;//= levelManagerPresenter.GetCols();
        string levelToPlay;//= levelManagerPresenter.GetLevelToPlay();

        levelToPlay = "mmmmmmmmmmmmmllllllllllmmllllllllllmmllllmmmlllmmllllmpmlllmmllllmlmlllmmmmmmmlmlllmmmlllllmlllmmmsllllmlllmmmmmmmmmlllmmllllllllllmmmmmmmmmmmmm";
        rows = 12;
        cols = 12;

        plane.transform.localScale = new Vector3(rows/5, 1, cols/5);
        plane.transform.position = new Vector3(rows / 2, 0, cols/2);
        //plane.transform.rotation = Quaternion.Euler(0, 90, 0) * plane.transform.rotation;
        camera.transform.position = new Vector3(rows / 2, 20, cols / 2);

        //SetObjectSize(rows, cols);
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

       // DestroyObjects();
    }

    /*private void SetObjectSize(int rows, int cols)
    {
        wall.transform.localScale = new Vector3(boardSizex / rows, wall.transform.localScale.y, boardSizey / cols);
        hole.transform.localScale = new Vector3(boardSizex / rows, hole.transform.localScale.y, boardSizey / cols);
    }*/

    private string[] SplitMapCode(string mapCode)
    {
        return mapCode.Split('#');
    }

    private int GetRows(string[] mapCodeSplitted)
    {
        return Int16.Parse(mapCodeSplitted[0]);
    }

    private int GetCols(string[] mapCodeSplitted)
    {
        return Int16.Parse(mapCodeSplitted[1]);
    }

    private string GetMap(string[] mapCodeSplitted)
    {
        return mapCodeSplitted[2];
    }

    private Vector3 GetNextPosition(int rows, int cols, int i, int j)
    {
        float nextPositionInRow = GetNextPositionInRow(rows, j);
        float nextPositionInColumn = GetNextPositionInColumn(cols, i);
        return new Vector3(nextPositionInRow, POSITIONY, nextPositionInColumn);
    }

    private float GetNextPositionInRow(int rows, int j)
    {
        return  j;
    }

    private float GetNextPositionInColumn(int cols, int i)
    {
        return i;
    }

    /*private void DestroyObjects()
    {
        Destroy(wall);
        Destroy(ball);
        Destroy(goal);
        Destroy(hole);
    }*/

}