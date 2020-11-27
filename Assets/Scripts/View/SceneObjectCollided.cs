using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectCollided : MonoBehaviour, Collidable
{
    private GameManagerGUI gameManagerGUI;

    public void ActionObjectCollided()
    {
        MessagesCollisionDictionary messagesCollisionDictionary = new MessagesCollisionDictionary();

        string nameObjectCollided = transform.name;

        Dictionary<string, string> messages = messagesCollisionDictionary.SetMessages();

        string messageCollision = messagesCollisionDictionary.GetMessage(nameObjectCollided);

        Debug.Log(messageCollision);
        //gameManagerGUI.GameResult(messageCollision);
    }
}
