using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelStorageManager{
	void Save(string newLevel);
	string Get(int level);
}
