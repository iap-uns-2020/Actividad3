
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardGUI : MonoBehaviour
{
    public GameObject wall;
    public GameObject hole;
    public GameObject goal;
    public GameObject ball;
    public GameObject board;

    const float POSITIONX = 445f;
    const float POSITIONY = 627.2f;
    const float POSITIONZ = -17554f;

    const int boardSize = 10;


    void Start()
    {
       CreateBoard();
    }

    public void CreateBoard()
    {
        string mapCode = "10#10#mmmmmmmmmmmllllllllmmlmmmmmmlmmlmllllmlmmlmmlmmmlmmlpmlmlllmmllmlmmmlmmmmmlhlhlmmsllllhlhmmmmmmmmmmm";

        string[] mapCodeSplitted = SplitMapCode(mapCode);
        int rows = GetRows(mapCodeSplitted);
        int cols = GetCols(mapCodeSplitted);
        string map = GetMap(mapCodeSplitted);
        SetObjectSize(rows, cols);
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                char objectRepresentation = map[k];
                k++;
                Vector3 objectPosition = GetNextPosition(rows, cols, i, j);
                GameObject objectToCreate = GetObject(objectRepresentation);
                createObject(objectToCreate, objectPosition);
            }
        }

        DestroyObjects();
    }

    private void SetObjectSize(int rows, int cols)
    {
        wall.transform.localScale = new Vector3(boardSize / rows, wall.transform.localScale.y, boardSize / cols);
        hole.transform.localScale = new Vector3(boardSize / rows, hole.transform.localScale.y, boardSize / cols);
    }

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

    private float GetNextPositionInRow(int rows, int col)
    {
        return POSITIONX - (boardSize / rows * col);
    }

    private float GetNextPositionInColumn(int cols, int i)
    {
        return POSITIONZ + (boardSize / cols * i);
    }

    private GameObject GetObject(char objectRepresentation)
    {
        GameObject objectToCreate = null;

        switch (objectRepresentation)
        {
            case 'm':
                objectToCreate = wall;
                break;
            case 'p':
                objectToCreate = ball;
                break;
            case 's':
                objectToCreate = goal;
                break;
            case 'h':
                objectToCreate = hole;
                break;
        }

        return objectToCreate;
    }

    private void createObject(GameObject objectToCreate, Vector3 position)
    {
        if (objectToCreate != null)
            Instantiate(objectToCreate, position, transform.rotation);
    }

    private void DestroyObjects()
    {
        Destroy(wall);
        Destroy(ball);
        Destroy(goal);
        Destroy(hole);
    }

}