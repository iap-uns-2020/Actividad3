using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardCreation.Model;

namespace BoardCreation.Presenter{
	public interface ISceneObjectManagerPresenter{
		SceneObjectCreator GetRawSceneObject(char type);
		bool Exists(char type);
	}		
}

