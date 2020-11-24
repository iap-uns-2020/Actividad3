﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevel{
	void Load(int level);
	int GetRows();
	int GetCols();
	string GetLevelToPlay();
}
