using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dialogue
{
    [System.Serializable]
    public struct lineData {
        public string name;
        public Sprite portrait;
        public string sentence;
    }
    public List<lineData> lines;
}
