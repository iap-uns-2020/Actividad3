using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collisions.Model{
	public class CollisionDictionary : ICollisionDictionary{
		private const int GAMEWON = 0;
		private const int GAMELOST = 1;
		private const string GOALNAME = "goalCollidable(Clone)";
		private const string HOLENAME = "holeCollidable(Clone)";

		private Dictionary<string, int> ObjectsCollision = new Dictionary<string, int>(){
			{GOALNAME, GAMEWON},
			{HOLENAME, GAMELOST},
		};

		public int GetPanelNumber(string objectCollided){
			return ObjectsCollision[objectCollided];
		}

	}
}

