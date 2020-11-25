using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelStorageManagerPresenter
{
	int LevelCounter();
	string Get(int level);
	void Save(string upcomingLevel);
	void SetCurrentLevel(int level);
	int GetCurrentLevel();
}
