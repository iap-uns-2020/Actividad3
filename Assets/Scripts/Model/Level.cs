using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level : ILevel{
	private char[,] map; 
	private ILevelStorageManager levelStorageManager;
	private string levelToPlay;
	private int rows, cols;

	public Level(){
		levelStorageManager = new LevelStorageManager();
		//levelStorageManager.Save("8#8#wwwwwwwwwffffffwwfhffffwwffwwwfwwfgwfffwwwwwfffwwbfffffwwwwwwwww");
	  	//PlayerPrefs.DeleteAll();
	}



	public void Load(int toLoad){
		ParseLevelParameters(toLoad);
		map = new char[rows,cols];
		int k=0;
		for(int i=0; i<rows; i++){
			for(int j=0; j<cols;j++){
				map[i,j]= levelToPlay[k];
				k++;
			}
		}
	}

	private void ParseLevelParameters(int levelNumber){
		string levelCode = levelStorageManager.Get(levelNumber);
		string[] mapCodeSplitted = levelCode.Split('#');
		rows = Int16.Parse(mapCodeSplitted[0]);
		cols = Int16.Parse(mapCodeSplitted[1]);
		levelToPlay = mapCodeSplitted[2];
	}

	public int GetRows(){
		return rows;
    }

	public int GetCols(){
		return cols;
	}

	public string GetLevelToPlay(){
		return levelToPlay;
    }
}