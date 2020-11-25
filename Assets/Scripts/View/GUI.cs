using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    public Button leftArrow;
    public Button rightArrow;
    public Text levelCounterText;
    private int imageLevelNumber;
    public Button buttonLevel;
    public Sprite[] levelImages;
    private int cantNiveles;
    private ILevelStorageManagerPresenter storageManagerPresenter;

    public Sprite levelTexture;

    void Start()
    {
        //levelImages = new Sprite[CANTIMAGENESDENIVELES];
        storageManagerPresenter = new LevelStorageManagerPresenter();
        cantNiveles = storageManagerPresenter.LevelCounter();
       
        imageLevelNumber = 0;
    }


    public void NextLevelImage(){   
        Debug.Log("next");
        if (imageLevelNumber< cantNiveles-1){
            imageLevelNumber++;
            levelCounterText.text = "Level "+imageLevelNumber;
        }

        //buttonLevel.GetComponent<Button>().GetComponent<Image>().sprite = levelTexture;
    }

    public void PreviousLevelImage(){
        Debug.Log("previous");
        if (imageLevelNumber > 0){
            imageLevelNumber--;
            levelCounterText.text = "Level "+imageLevelNumber;
        }
        //buttonLevel.GetComponent<Button>().GetComponent<Image>().sprite = levelTexture;
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel(){
        
    }
}

