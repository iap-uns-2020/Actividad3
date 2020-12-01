using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TimeRegister.Model;
using TimeRegister.View;

namespace TimeRegister.Presenter{
	public class TimeStorageManagerPresenter : ITimeStorageManagerPresenter{

		private ITimeStorageManager timeStorageManager;

		public TimeStorageManagerPresenter() {
			timeStorageManager = new TimeStorageManager();
		}


		public void RegisterStartTime()
        {
			timeStorageManager.RegisterStartTime();
		}

		public void RegisterFinnishTime(){
			timeStorageManager.RegisterFinnishTime();
		}

		public void Save(int level, TimeSpan timeSpan){
			timeStorageManager.Save(level,timeSpan);
		}

		public string Get(int level){
			return timeStorageManager.Get(level);
		}
	}	
}

