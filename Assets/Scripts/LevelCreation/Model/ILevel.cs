using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelCreation.Model
{
	public interface ILevel
	{
		void Load(int level);
		int GetRows();
		int GetCols();
		string GetLevelToPlay();
	}
}
