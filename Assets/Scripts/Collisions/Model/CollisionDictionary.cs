using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collisions.Model{
	public class CollisionDictionary : ICollisionDictionary{
		private const int GAMEWON = 0;
		private const int GAMELOST = 1;
		private const string GOALNAME = "goal(Clone)";
		private const string HOLENAME = "hole(Clone)";

		private Dictionary<string, int> ObjectsCollision = new Dictionary<string, int>(){
			{GOALNAME, GAMEWON},
			{HOLENAME, GAMELOST},
		};

		public int GetPanelNumber(string objectCollided){
			return ObjectsCollision[objectCollided];
		}

	}
}

