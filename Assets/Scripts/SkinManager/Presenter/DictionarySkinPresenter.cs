using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkinManager
{
    public class DictionarySkinPresenter : IDictionarySkinPresenter
    {
        private IDictionarySkin dictionarySkin;

        public DictionarySkinPresenter()
        {
            dictionarySkin = new DictionarySkin();
        }

        public string GetNameSkin(int level)
        {
            return dictionarySkin.GetNameSkin(level);
        }

        public bool Exists(int level)
        {
            return dictionarySkin.Exists(level);
        }
    }
}
