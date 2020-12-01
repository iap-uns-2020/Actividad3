using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BoardCreation.Model{
    public class SceneObjectManager : ISceneObjectManager{
        private Dictionary<char,SceneObjectCreator> sceneObjectDictionary = new Dictionary<char,SceneObjectCreator>(){
            {'w', new Wall()},
            {'b', new Ball()},
            {'h', new Hole()},
            {'g', new Goal()},
            {'p', new Plane()},
        };

        public SceneObjectCreator GetRawSceneObject(char type){
            return sceneObjectDictionary[type];
        }

        public bool Exists(char type){
            return sceneObjectDictionary.ContainsKey(type);
        }
    }   
}

