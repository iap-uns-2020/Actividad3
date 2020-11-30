using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model
{
    public interface IHeightDictionary
    {
        float GetHeight(string objectNotCollidable);
        bool Exists(string model);
    }
}
