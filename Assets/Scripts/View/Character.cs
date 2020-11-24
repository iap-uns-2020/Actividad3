using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public Character(string model, Vector3 position)
    {
        Quaternion randomRotation = Quaternion.Euler(0,0, 0);
        GameObject aux = MonoBehaviour.Instantiate(Resources.Load("Objects/"+model), position, randomRotation) as GameObject;
    }

}
