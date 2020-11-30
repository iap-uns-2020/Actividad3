using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkinManager
{
    public class DictionarySkin : IDictionarySkin
    {
        private Dictionary<int, string> myDictionarySkin;

        public DictionarySkin()
        {
            myDictionarySkin = new Dictionary<int, string>()
        {
            {1,"Fire"},
            {2,"Stone"},
            {3,"Ice"}
        };
        }

        public string GetNameSkin(int level)
        {
            return myDictionarySkin[level];
        }

        public bool Exists(int level)
        {
            return myDictionarySkin.ContainsKey(level);
        }
    }
}