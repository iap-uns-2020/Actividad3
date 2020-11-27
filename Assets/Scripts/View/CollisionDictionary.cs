using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDictionary
{
	private Dictionary<string, int> ObjectsCollision;
	private const int GAMEWON = 0;
	private const int GAMELOST = 1;
	private const string GOALNAME = "goal(Clone)";
	private const string HOLENAME = "hole(Clone)";

	public void SetMessages()
	{
		ObjectsCollision = new Dictionary<string, int>();

		ObjectsCollision.Add(GOALNAME, GAMEWON);
		ObjectsCollision.Add(HOLENAME, GAMELOST);
	}

	public int GetMessage(string objectCollided)
	{
		return ObjectsCollision[objectCollided];
	}

}
