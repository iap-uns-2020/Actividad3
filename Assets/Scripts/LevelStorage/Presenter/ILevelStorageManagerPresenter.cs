using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelCreation.Presenter
{
	public interface ILevelStorageManagerPresenter
	{
		int LevelCounter();
		string Get(int level);
		void Save(string upcomingLevel);
	}
}