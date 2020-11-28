using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PanelTransitionManager.View
{
    public interface IGUIPanelManager
    {
        void PlayButtonListener();
        void AddNewLevelListener();
        void NewPanel(GameObject panel);
    }
}