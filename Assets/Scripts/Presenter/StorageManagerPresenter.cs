using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageManagerPresenter : IStorageManagerPresenter
{
    private ILevelStorageManager storageManager;

    public StorageManagerPresenter()
    {
        storageManager = new LevelStorageManager();
    }

    public int LevelCounter()
    {
        return storageManager.LevelCounter();
    }
}