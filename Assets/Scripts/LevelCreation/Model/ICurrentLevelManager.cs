using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelCreation.Model
{
	public interface ICurrentLevelManager
	{
		void SetCurrentLevel(int level);
		int GetCurrentLevel();
	}
}
