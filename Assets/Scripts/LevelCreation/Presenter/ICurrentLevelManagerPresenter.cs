using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LevelCreation.Presenter
{
	public interface ICurrentLevelManagerPresenter
	{
		void SetCurrentLevel(int level);
		int GetCurrentLevel();
	}
}
