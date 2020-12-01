using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collisions.Model;

namespace BoardCreation.Model{
    public abstract class SceneObjectCreator{
        private GameObject gameObject;
        private GameObject ball;
        private string model;
        private string theme;
        private IHeightDictionary heightDictionary;
        
        public SceneObjectCreator(string model){
            this.model = model;
            theme = "generic";
            heightDictionary = new HeightDictionary();
        }

        public void SetTheme(string theme){
            this.theme = theme;
        }

        public void Place(int x, int z){
            float y = 0f;
            
            if(heightDictionary.Exists(model))
                y = heightDictionary.GetHeight(model);

            Vector3 position = new Vector3(x, y, z);
            Quaternion rotation = Quaternion.Euler(0,0,0);
            gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects"+"/"+theme+"/"+model), position, rotation) as GameObject;
        }    
    }  
}

