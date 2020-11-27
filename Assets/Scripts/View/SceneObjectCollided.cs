using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneObjectCollided : MonoBehaviour, Collidable
{
    private GameManagerGUI gameManagerGUI;
    public GameObject winPanel;
    public GameObject losePanel;

    public void ActionObjectCollided(){
        MessagesCollisionDictionary messagesCollisionDictionary = new MessagesCollisionDictionary();
        string nameObjectCollided = transform.name;
        Dictionary<string, string> messages = messagesCollisionDictionary.SetMessages();
        string messageCollision = messagesCollisionDictionary.GetMessage(nameObjectCollided);
        
        if(string.Compare(messageCollision, "You Won!")==0)
            Instantiate(winPanel);
        else
            Instantiate(losePanel);
        
        //gameManagerGUI.GameResult(messageCollision);

    }
}
