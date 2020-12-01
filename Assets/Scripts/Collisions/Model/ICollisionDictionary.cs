using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collisions.Model{
	public interface ICollisionDictionary {
		int GetSceneNumber(string objectCollided);
	}	
}

