using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningManager : MonoBehaviour
{
	public Text waitText;
	private int i=0;
	private const int MAINMENUSCENE = 0;
    void Start(){
       StartCoroutine(OpeningAnimation()); 
    }

    private IEnumerator OpeningAnimation(){
    
    	for(int i=0; i<3; i++){
    		waitText.text+='.';	
    		yield return new WaitForSeconds(1);
    	} 
    	SceneManager.LoadScene(MAINMENUSCENE);  
    }

}
