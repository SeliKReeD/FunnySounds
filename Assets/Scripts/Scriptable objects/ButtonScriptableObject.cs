using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptableObject : ScriptableObject
{
    [SerializeField]
    public List<ButtonObject> buttons;
}
