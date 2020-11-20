using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : ILevel{
	private int[,] map; 
	private ILevelStorageManager levelStorageManager;

	public Level(){
		levelStorageManager = new LevelStorageManager();
		map = new int[50,50];
	}

	public void Load(int toLoad){
		int k=0;
		string levelToPlay = levelStorageManager.Get(toLoad);
		for(int i=0; i<50; i++){
			for(int j=0; j<50;j++){
				map[i,j]= levelToPlay[k];
				k++;
			}
		}
	}
}