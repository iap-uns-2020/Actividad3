using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkinManager
{
    public interface IDictionarySkinPresenter
    {
        string GetNameSkin(int level);
        bool Exists(int level);
    }
}
