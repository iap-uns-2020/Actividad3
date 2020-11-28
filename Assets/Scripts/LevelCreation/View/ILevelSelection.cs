using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelCreation.View
{
    public interface ILevelSelection
    {
        void SelectNextLevel();
        void SelectPreviousLevel();
        void SelectFirstLevel();
    }
}
