﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStorage.Model
{
	public interface ILevelStorageManager
	{
		void Save(string newLevel);
		string Get(int level);
		int LevelCounter();
		void Preload();
	}
}
