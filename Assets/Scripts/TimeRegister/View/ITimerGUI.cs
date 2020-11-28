using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TimeRegister.View
{
    public interface ITimerGUI
    {
        void RegisterStartTime();
        void ShowTimeSpendInLevel(int currentLevel);
    }
}
