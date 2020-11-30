using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model
{
	public class HeightDictionary : IHeightDictionary
	{
		private const string BALLCODE = "ball";
		private const string HOLECODE = "holeNotCollidable";
		private const string GOALCODE = "goalNotCollidable";
		private const string WALLCODE = "wall";
		private const float BALLHEIGHT = 0.5f;
		private const float COMMONHEIGHT = 0.0f;

		private Dictionary<string, float> notCollidableToCollidable = new Dictionary<string, float>(){
			{BALLCODE, BALLHEIGHT},
			{HOLECODE, COMMONHEIGHT},
			{GOALCODE, COMMONHEIGHT},
			{WALLCODE, COMMONHEIGHT},
		};

		public float GetHeight(string objectNotCollidable)
		{
			return notCollidableToCollidable[objectNotCollidable];
		}

		public bool Exists(string model)
		{
			return notCollidableToCollidable.ContainsKey(model);
		}
	}
}
