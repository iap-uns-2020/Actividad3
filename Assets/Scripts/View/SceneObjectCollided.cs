using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Collisions.Presenter;

namespace Collisions.View{
    public class SceneObjectCollided : MonoBehaviour, Collidable{
        private ICollisionManagerPresenter collisionManagerPresenter;
        public GameObject[] panels;

        void Start(){
            collisionManagerPresenter = new CollisionManagerPresenter();
        }

        public void ActionObjectCollided(){
            string nameObjectCollided = transform.name;
            int panelCollisionNumber = collisionManagerPresenter.GetPanelNumber(nameObjectCollided);
            GameObject gameObject = Instantiate(panels[panelCollisionNumber]);
        }
    }    
}

