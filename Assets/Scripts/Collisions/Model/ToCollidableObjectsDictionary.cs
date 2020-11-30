using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collisions.Model
{
	public class ToCollidableObjectsDictionary : IToCollidableObjectsDictionary
	{

		private const string NOTCOLLIDABLEHOLE = "holeNotCollidable";
		private const string COLLIDABLEHOLE = "holeCollidable";
		private const string NOTCOLLIDABLEGOAL = "goalNotCollidable";
		private const string COLLIDABLEGOAL = "goalCollidable";

		private Dictionary<string, string> notCollidableToCollidable = new Dictionary<string, string>(){
			{NOTCOLLIDABLEHOLE, COLLIDABLEHOLE},
			{NOTCOLLIDABLEGOAL, COLLIDABLEGOAL},
		};

		public string GetCollidable(string objectCollidable)
		{
			return notCollidableToCollidable[objectCollidable];
		}

		public bool Exists(string model)
        {
			return notCollidableToCollidable.ContainsKey(model);
		}
	}
}
