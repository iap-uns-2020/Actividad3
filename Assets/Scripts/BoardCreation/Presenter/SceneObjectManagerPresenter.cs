﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardCreation.Model;

namespace BoardCreation.Presenter{
	public class SceneObjectManagerPresenter : ISceneObjectManagerPresenter{
		private SceneObjectManager sceneObjectManager;

		public SceneObjectManagerPresenter(){
			sceneObjectManager = new SceneObjectManager();
		}
		
		public SceneObject GetRawSceneObject(char type){
			return sceneObjectManager.GetRawSceneObject(type);
		}

		public bool Exists(char type){
			return sceneObjectManager.Exists(type);
		}
	}	
}
