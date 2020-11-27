using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    public TimerGUI timerGUI;
    public Button leftArrow;
    public Button rightArrow;
    public Button buttonLevel;
    public Text levelCounterText;
    private int currentLevel;
    private int cantNiveles;
    private ILevelStorageManagerPresenter storageManagerPresenter;
    private ICurrentLevelManagerPresenter currentLevelManagerPresenter;



    void Start(){
        storageManagerPresenter = new LevelStorageManagerPresenter();
        storageManagerPresenter.Save("10#10#wwwwwwwwwwwfwffffffwwfffhffffwwffffffffwwffffffffwwffhfhfffwwffffffffwwfffffffbwwgwfffffwwwwwwwwwwww");
        currentLevelManagerPresenter = new CurrentLevelManagerPresenter();
        cantNiveles = storageManagerPresenter.LevelCounter();
        SelectFirstLevel();
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



    private void SelectFirstLevel(){
        if(cantNiveles>0){
            currentLevel = 1;
            levelCounterText.text = "Level "+currentLevel;   
        }
    }


    private void ChangeScene(){
        SceneManager.LoadScene(1);
    }

    private void NotifyTimer(){
        timerGUI.SetLevel(currentLevel);
    }

    private void SetSelectedLevel(){
        currentLevelManagerPresenter.SetCurrentLevel(currentLevel);
    }




}

