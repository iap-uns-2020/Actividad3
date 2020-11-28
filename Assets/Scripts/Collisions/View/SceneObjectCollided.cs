using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TimeRegister.Model;
using Collisions.Presenter;

namespace Collisions.View{
    public class SceneObjectCollided : MonoBehaviour, Collidable{
        private ICollisionManagerPresenter collisionManagerPresenter;
        public GameObject[] panels;
        private TimeStorageManager timeStorageManager;

        void Start(){
            collisionManagerPresenter = new CollisionManagerPresenter();
            timeStorageManager = new TimeStorageManager();
        }

        public void ActionObjectCollided(){
            string nameObjectCollided = transform.name;
            int panelCollisionNumber = collisionManagerPresenter.GetPanelNumber(nameObjectCollided);
            GameObject gameObject = Instantiate(panels[panelCollisionNumber]);
            if(panelCollisionNumber==1)
                timeStorageManager.RegisterFinnishTime();
        }
    }    
}

