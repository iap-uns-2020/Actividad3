using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using TimeRegister.Presenter;

namespace TimeRegister.View{

	public class TimerGUI : MonoBehaviour, ITimerGUI{

		public Text textTime;
	    private ITimeStorageManagerPresenter timeStorageManagerPresenter;

        void Start()
        {
			timeStorageManagerPresenter = new TimeStorageManagerPresenter();
			ShowTimeSpendInLevel(1);

		}

		public void RegisterStartTime()
        {
			timeStorageManagerPresenter.RegisterStartTime();
		}


	    public void ShowTimeSpendInLevel(int currentLevel)
	    {
			string currentTime = timeStorageManagerPresenter.Get(currentLevel);
			textTime.text = currentTime;
	    }

	}	
}
