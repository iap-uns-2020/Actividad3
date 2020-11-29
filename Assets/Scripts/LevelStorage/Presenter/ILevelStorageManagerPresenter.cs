using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelStorage.Presenter
{
	public interface ILevelStorageManagerPresenter{
		int LevelCounter();
		string Get(int level);
		void Save(string upcomingLevel);
		void Preload();
	}
}