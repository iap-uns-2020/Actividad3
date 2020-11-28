using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TimeRegister.Model{
	public interface ITimeStorageManager{
		void Save(int level, TimeSpan time);
		string Get(int level);
	}	
}

