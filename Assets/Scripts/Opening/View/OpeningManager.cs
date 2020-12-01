using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Opening{
	public class OpeningManager : MonoBehaviour, IOpeningManager{
		private const int MAINMENUSCENE = 0;
		private const int SECONDSTOWAIT = 1;
		public Text waitText;
	    void Start(){
	       StartCoroutine(OpeningAnimation()); 
	    }

	    private IEnumerator OpeningAnimation(){
	    
	    	for(int i=0; i<3; i++){
	    		waitText.text+='.';	
	    		yield return new WaitForSeconds(SECONDSTOWAIT);
	    	} 
	    	SceneManager.LoadScene(MAINMENUSCENE);  
	    }

	}	
}

