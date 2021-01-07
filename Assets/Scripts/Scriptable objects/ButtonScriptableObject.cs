using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptableObject : ScriptableObject
{
    [Serializable]
    public struct ButtonObject
    {
        public int id;

        public AudioClip Clip;
        public Sprite sprite;
    }

    [SerializeField]
    public List<ButtonObject> buttons;
}
