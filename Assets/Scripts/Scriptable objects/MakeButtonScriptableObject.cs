using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakeButtonScriptableObject
{
    [MenuItem("Assets/Create/Button Object")]
    public static void CreateMyAsset()
    {
        ButtonScriptableObject buttonAsset = ScriptableObject.CreateInstance<ButtonScriptableObject>();

        AssetDatabase.CreateAsset(buttonAsset, "Assets/NewScriptableObject.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = buttonAsset;
    }
}
