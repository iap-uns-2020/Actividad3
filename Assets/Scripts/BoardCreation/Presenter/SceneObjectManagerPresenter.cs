using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardCreation.Model;

namespace BoardCreation.Presenter{
	public class SceneObjectManagerPresenter : ISceneObjectManagerPresenter{
		private ISceneObjectManager sceneObjectManager;

		public SceneObjectManagerPresenter(){
			sceneObjectManager = new SceneObjectManager();
		}
		
		public SceneObjectCreator GetRawSceneObject(char type){
			return sceneObjectManager.GetRawSceneObject(type);
		}

		public bool Exists(char type){
			return sceneObjectManager.Exists(type);
		}
	}	
}

