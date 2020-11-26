using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsManager
{
    private int rows, cols, i, j;
    private char[,] map;

    private float accumulateMovementInX;
    private float accumulateMovementInZ;

    public CollisionsManager()
    {
        accumulateMovementInX = 0;
        accumulateMovementInZ = 0;
    }

    public void setSizeOfMap(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
    }

    public void SetObjectPosition(char mapObject, int i, int j)
    {
        map[i, j] = mapObject;
        if (mapObject == 'p')
        {
            this.i = i;
            this.j = j;
        }
    }


    public void UpdatePlayerPosition(int rowsOffset, int colsOffset)
    {
        i += rowsOffset;
        j += colsOffset;
        if(i<rows-1 && j<cols-1)
            map[i,j] = 'b';
    }


    private void CheckCollisions()
    {
        bool gameWon = CheckCollisionsWithGoal();
        bool gameLost = CheckCollisionsWithHole();
    }

    private bool CheckCollisionsWithGoal()
    {
        return map[i, j] == 'g';
    }

    private bool CheckCollisionsWithHole()
    {
        return map[i, j] == 'h';
    }

}
