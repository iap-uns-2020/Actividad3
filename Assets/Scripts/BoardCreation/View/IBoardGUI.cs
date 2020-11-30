using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.View
{
    public interface IBoardGUI
    {
        void StartLevel(int level);
        void CreateBoard();
    }
}
