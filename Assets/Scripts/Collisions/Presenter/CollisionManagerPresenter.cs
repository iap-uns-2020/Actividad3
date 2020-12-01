using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collisions.Model;

namespace Collisions.Presenter{
	public class CollisionManagerPresenter : ICollisionManagerPresenter{
		private ICollisionDictionary collisionDictionary;

		public CollisionManagerPresenter(){
			collisionDictionary = new CollisionDictionary();
		}

		public int GetSceneNumber(string objectCollided){
			return collisionDictionary.GetSceneNumber(objectCollided);
		}
	}	
}

