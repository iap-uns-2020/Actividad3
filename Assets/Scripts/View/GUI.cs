using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    public Button leftArrow;
    public Button rightArrow;
    private int imageLevelNumber;
    public Button buttonLevel;
    public Sprite[] levelImages;
    private int cantNiveles;
    private IStorageManagerPresenter storageManagerPresenter;

    public Sprite levelTexture;

    void Start()
    {
        //levelImages = new Sprite[CANTIMAGENESDENIVELES];
        storageManagerPresenter = new StorageManagerPresenter();
        cantNiveles = storageManagerPresenter.LevelCounter();
       
        imageLevelNumber = 0;
    }


    public void NextLevelImage()
    {
        if (imageLevelNumber< cantNiveles-1)
            imageLevelNumber++;
        buttonLevel.GetComponent<Button>().GetComponent<Image>().sprite = levelTexture;
    }

    public void PreviousLevelImage()
    {
        if (imageLevelNumber > 0)
            imageLevelNumber--;
        buttonLevel.GetComponent<Button>().GetComponent<Image>().sprite = levelTexture;
    }
}

