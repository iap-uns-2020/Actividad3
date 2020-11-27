using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneObject
{
	private GameObject gameObject;
    private GameObject ball;
    private string model;
	private string theme;
    public SceneObject(string model){
    	this.model = model;
    	theme = "";
    }

    public void SetTheme(string theme){
    	this.theme = theme;
    }

    public void Place(Vector3 position){
    	Quaternion randomRotation = Quaternion.Euler(0,0, 0);
        gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects/"+model+theme), position, randomRotation) as GameObject;
        if (string.Compare(this.model, "ball") == 0)
        {
            ball = gameObject;
            Debug.Log("comparacion pelota");
        }
    }

    public void DestroyBall()
    {
        MonoBehaviour.Destroy(ball);
        Debug.Log("llegue a destroy ball");
    }

}
