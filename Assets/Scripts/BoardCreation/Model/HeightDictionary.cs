using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model
{
	public class HeightDictionary : IHeightDictionary
	{
		private const string BALLCODE = "ball";
		private const string HOLECODE = "hole";
		private const string GOALCODE = "goal";
		private const string WALLCODE = "wall";
		private const string PLANECODE = "plane";
		private const float BALLHEIGHT = 0.5f;
		private const float COMMONHEIGHT = 0.0f;

		private Dictionary<string, float> heightSelector = new Dictionary<string, float>(){
			{BALLCODE, BALLHEIGHT},
			{HOLECODE, COMMONHEIGHT},
			{GOALCODE, COMMONHEIGHT},
			{WALLCODE, COMMONHEIGHT},
			{PLANECODE, -0.025f},
		};

		public float GetHeight(string model)
		{
			return heightSelector[model];
		}

		public bool Exists(string model)
		{
			return heightSelector.ContainsKey(model);
		}
	}
}
