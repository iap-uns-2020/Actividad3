using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Collisions.Model
{
    public interface IToCollidableObjectsDictionary
    {
        string GetCollidable(string objectCollidable);
        bool Exists(string model);
    }
}