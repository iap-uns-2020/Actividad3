using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model{
    public abstract class SceneObject{
        private GameObject gameObject;
        private GameObject ball;
        private string model;
        private string theme;
        public SceneObject(string model){
            this.model = model;
            theme = "generic";
        }

        public void SetTheme(string theme){
            this.theme = theme;
        }

        public void Place(Vector3 position){
            Quaternion randomRotation = Quaternion.Euler(0,0, 0);
            gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects"+"/"+theme+"/"+model), position, randomRotation) as GameObject;
        }
    }  
}

