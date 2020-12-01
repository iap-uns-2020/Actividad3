using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model
{
    public interface IHeightDictionary
    {
        float GetHeight(string sceneObjectType);
        bool Exists(string model);
    }
}
