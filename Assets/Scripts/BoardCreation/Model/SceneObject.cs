using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collisions.Model;

namespace BoardCreation.Model{
    public abstract class SceneObject{
        private GameObject gameObject;
        private GameObject ball;
        private string model;
        private string theme;
        private IHeightDictionary heightDictionary;
        private IToCollidableObjectsDictionary toCollidableObjectsDictionary;
        public SceneObject(string model){
            this.model = model;
            theme = "generic";
            heightDictionary = new HeightDictionary();
            toCollidableObjectsDictionary = new ToCollidableObjectsDictionary();
        }

        public void SetTheme(string theme){
            this.theme = theme;
        }

        public void Place(int x, int z){
            float y = 0f;
            Quaternion rotation = Quaternion.Euler(0,0,0);
            Debug.Log("NO COLLIDABLE"+model);
            if(heightDictionary.Exists(model))
                y = heightDictionary.GetHeight(model);
            Vector3 position = new Vector3(x, y, z);
            gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects"+"/"+theme+"/"+model), position, rotation) as GameObject;
            if (toCollidableObjectsDictionary.Exists(model))
            {
                model = toCollidableObjectsDictionary.GetCollidable(model);
                Debug.Log("COLLIDABLE"+model);
                InstantiateCollidable(position, rotation);
            }

        }

        private void InstantiateCollidable(Vector3 position, Quaternion rotation){
            gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects"+"/"+theme+"/"+model), position, rotation) as GameObject;
            gameObject.transform.localScale = new Vector3(0.08f,0.08f,0.08f);  
        }
    }  
}

