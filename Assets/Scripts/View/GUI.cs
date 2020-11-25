using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    public TimerGUI timerGUI;
    public BoardGUI boardGUI;
    public Button leftArrow;
    public Button rightArrow;
    public Button buttonLevel;
    public Text levelCounterText;
    private int currentLevel;
    private int cantNiveles;
    private ILevelStorageManagerPresenter storageManagerPresenter;


    void Start(){
        storageManagerPresenter = new LevelStorageManagerPresenter();
        cantNiveles = storageManagerPresenter.LevelCounter();
        Debug.Log("cant niveles: "+cantNiveles);
        SelectFirstLevel();
    }

    private void SelectFirstLevel(){
        if(cantNiveles>0){
            currentLevel = 1;
            levelCounterText.text = "Level "+currentLevel;   
        }
    }

    public void SelectNextLevel(){   
        if (currentLevel<cantNiveles){
            currentLevel++;
            levelCounterText.text = "Level "+currentLevel;
        }
    }

    public void SelectPreviousLevel(){
        if (currentLevel > 1){
            currentLevel--;
            levelCounterText.text = "Level "+currentLevel;
        }
    }


    public void ChangeScene(){
        SceneManager.LoadScene(1);
    }

    public void NotifyTimer(){
        timerGUI.SetLevel(currentLevel);
    }

    public void SetSelectedLevel(){
        Debug.Log("current level: "+ currentLevel);
        storageManagerPresenter.SetCurrentLevel(currentLevel);
    }


}

