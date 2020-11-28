using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BoardCreation.Model{
    public class SceneObjectManager : ISceneObjectManager{
        private Dictionary<char,SceneObject> sceneObjectDictionary = new Dictionary<char,SceneObject>(){
            {'w', new Wall()},
            {'b', new Ball()},
            {'h', new Hole()},
            {'g', new Goal()},
        };

        public SceneObject GetRawSceneObject(char type){
            return sceneObjectDictionary[type];
        }

        public bool Exists(char type){
            return sceneObjectDictionary.ContainsKey(type);
        }
    }   
}

