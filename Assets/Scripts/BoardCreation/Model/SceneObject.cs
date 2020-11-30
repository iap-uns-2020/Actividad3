using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoardCreation.Model{
    public abstract class SceneObject{
    	private const string NOTCOLLIDABLEGOAL = "goalNotCollidable";
    	private const string COLLIDABLEGOAL = "goalCollidable";
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

        public void Place(int x, int z){
            float y = 0f;
            Quaternion rotation = Quaternion.Euler(0,0, 0);
            if(string.Compare("ball",model)==0)
                y=0.5f;
            Vector3 position = new Vector3(x,y,z);
           // position.y=DictionaryHeight.GetHeight(model)
            gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects"+"/"+theme+"/"+model), position, rotation) as GameObject; 
            if(string.Compare(model, NOTCOLLIDABLEGOAL)==0){
        		model = "goalCollidable";
                InstantiateCollidable(position, rotation);
        	}

            if(string.Compare(model,"holeNotCollidable")==0){
                model = "holeCollidable";
                InstantiateCollidable(position, rotation);
            }
        }

        private void InstantiateCollidable(Vector3 position, Quaternion rotation){
            gameObject = MonoBehaviour.Instantiate(Resources.Load("Objects"+"/"+theme+"/"+model), position, rotation) as GameObject;
            gameObject.transform.localScale = new Vector3(0.02f,0.02f,0.02f);  
        }
    }  
}

