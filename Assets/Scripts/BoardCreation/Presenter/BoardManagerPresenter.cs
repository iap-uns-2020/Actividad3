using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardCreation.View;
using BoardCreation.Model;

namespace BoardCreation.Presenter
{
    public class BoardManagerPresenter : IBoardManagerPresenter
    {
        private IBoardManager boardManager;
        private IBoardGUI board;

        public BoardManagerPresenter(IBoardGUI view, IBoardManager model)
        {
            boardManager = model;
            board = view;
        }

        public void Load(int levelNumber)
        {
            boardManager.Load(levelNumber);
        }

        public int GetRows()
        {
            return boardManager.GetRows();
        }

        public int GetCols()
        {
            return boardManager.GetCols();
        }

        public string GetLevelToPlay()
        {
            return boardManager.GetLevelToPlay();
        }
    }
}
