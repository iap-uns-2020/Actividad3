using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITimeStorageManagerPresenter{
	void Save(int level, TimeSpan time);
	string Get(int level);
}
