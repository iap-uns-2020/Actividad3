using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collisions.Model{
	public class CollisionDictionary : ICollisionDictionary{
		private const int WINSCENE = 3;
		private const int LOSESCENE = 2;
		private const string GOALNAME = "goal(Clone)";
		private const string HOLENAME = "hole(Clone)";

		private Dictionary<string, int> objectsCollision = new Dictionary<string, int>(){
			{GOALNAME, WINSCENE},
			{HOLENAME, LOSESCENE},
		};

		public int GetSceneNumber(string objectCollided){
			return objectsCollision[objectCollided];
		}

	}
}

