using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TimeRegister.Model;
using UnityEngine.SceneManagement;
using Collisions.Presenter;

namespace Collisions.View{
    public class SceneObjectCollided : MonoBehaviour, Collidable{

        private ICollisionManagerPresenter collisionManagerPresenter;
        private TimeStorageManager timeStorageManager;

        void Start(){
            collisionManagerPresenter = new CollisionManagerPresenter();
            timeStorageManager = new TimeStorageManager();
        }

        public void ActionObjectCollided(){
            string nameObjectCollided = transform.name;
            timeStorageManager.RegisterFinnishTime();
            SceneManager.LoadScene(collisionManagerPresenter.GetPanelNumber(nameObjectCollided));
        }
    }
}

