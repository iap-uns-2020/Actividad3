using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICurrentLevelManager{
	void SetCurrentLevel(int level);
	int GetCurrentLevel();
}
