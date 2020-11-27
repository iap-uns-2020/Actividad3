using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagesCollisionDictionary
{
	private Dictionary<string, string> messageObjectCollision;
	private const string GAMEWONMESSAGE = "You Won!";
	private const string GAMELOSTMESSAGE = "You Lost!";
	private const string GOALNAME = "goal(Clone)";
	private const string HOLENAME = "hole(Clone)";

	public Dictionary<string, string> SetMessages()
	{
		messageObjectCollision = new Dictionary<string, string>();

		messageObjectCollision.Add(GOALNAME, GAMEWONMESSAGE);
		messageObjectCollision.Add(HOLENAME, GAMELOSTMESSAGE);

		return messageObjectCollision;
	}

	public string GetMessage(string objectCollided)
	{
		return messageObjectCollision[objectCollided];
	}

}
