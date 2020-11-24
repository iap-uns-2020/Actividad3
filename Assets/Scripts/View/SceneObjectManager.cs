using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectManager : MonoBehaviour
{

    public void Create(char sceneObject, Vector3 position)
    {
        switch (sceneObject)
        {
            case 'm':
                new Wall(position);
                break;
            case 'p':
                //new Ball(position);
                break;
            case 's':
                //new Hole(position);
                break;
            case 'h':
                //new Goal(position);
                break;
        }

    }
}
