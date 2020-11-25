using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICurrentLevelManagerPresenter {
	void SetCurrentLevel(int level);
	int GetCurrentLevel();
}
