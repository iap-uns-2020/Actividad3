using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneObjectCollided : MonoBehaviour, Collidable
{
    private GameManagerGUI gameManagerGUI;
    private CollisionDictionary CollisionDictionary;
    public GameObject[] panels;

    void Start(){
        CollisionDictionary = new CollisionDictionary();
    }

    public void ActionObjectCollided(){
        string nameObjectCollided = transform.name;
        int panelCollisionNumber = CollisionDictionary.GetMessage(nameObjectCollided);
        Instantiate(panels[panelCollisionNumber]);
        /*if(string.Compare(messageCollision, "You Won!")==0)
            Instantiate(winPanel);
        else
            Instantiate(losePanel);*/
        
        //gameManagerGUI.GameResult(messageCollision);

    }
}
