using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LevelStorage.Presenter;

namespace LevelStorage.View{
	public class LevelPreloader : MonoBehaviour, ILevelPreloader{
		private ILevelStorageManagerPresenter levelStorageManagerPresenter;
	    void Start(){
	        levelStorageManagerPresenter = new LevelStorageManagerPresenter();
	        levelStorageManagerPresenter.Preload();
	    }
	}	
}

