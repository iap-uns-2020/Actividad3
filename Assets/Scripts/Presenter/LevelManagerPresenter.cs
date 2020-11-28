﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardCreation.View;

public class LevelManagerPresenter : ILevelManagerPresenter
{
    private ILevel levelManager;
    private BoardGUI board;

    public LevelManagerPresenter(BoardGUI view, Level model)
    {
        levelManager = model;
        board = view;
    }

    public void Load(int levelNumber){
        levelManager.Load(levelNumber);
    }

    public int GetRows()
    {
        return levelManager.GetRows();
    }

    public int GetCols()
    {
        return levelManager.GetCols();
    }

    public string GetLevelToPlay()
    {
        return levelManager.GetLevelToPlay();
    }
}
