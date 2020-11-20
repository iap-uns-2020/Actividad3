using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManagerPresenter
{
    private IStorageManager storageManager;

    public StorageManagerPresenter()
    {
        storageManager = new StorageManager();
    }

    public int LevelCounter()
    {
        return storageManager.LevelCounter();
    }
}