using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkinManager
{
    public interface IDictionarySkin
    {
        string GetNameSkin(int level);
        bool Exists(int level);
    }
}