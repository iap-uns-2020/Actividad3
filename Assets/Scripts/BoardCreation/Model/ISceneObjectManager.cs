﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model{
	public interface ISceneObjectManager{
		SceneObjectCreator GetRawSceneObject(char type);
		bool Exists(char type);
	}	
}

