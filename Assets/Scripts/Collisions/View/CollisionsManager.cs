﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Collisions.View{
	public class CollisionsManager : MonoBehaviour{
	    private void OnTriggerEnter(Collider collision){
	        collision.gameObject.GetComponent<Collidable>().ActionObjectCollided();
	    }
	}	
}

