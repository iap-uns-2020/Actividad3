using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStorageManager : ITimeStorageManager{
	public Time Get(){
		return new Time();
	}

	public void Save(Time time){
		
	}
}