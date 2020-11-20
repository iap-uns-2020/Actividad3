using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITimeStorageManager{
	void Save(Time time);
	Time Get();
}
