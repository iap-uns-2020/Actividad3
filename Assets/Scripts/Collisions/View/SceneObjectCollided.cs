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

        void Start(){
            collisionManagerPresenter = new CollisionManagerPresenter();        }

        public void ActionObjectCollided(){
            string nameObjectCollided = transform.name;
            SceneManager.LoadScene(collisionManagerPresenter.GetPanelNumber(nameObjectCollided));
        }
    }
}

