using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TimeRegister.Presenter{
	public interface ITimeStorageManagerPresenter{
		void Save(int level, TimeSpan time);
		string Get(int level);
	}	
}

