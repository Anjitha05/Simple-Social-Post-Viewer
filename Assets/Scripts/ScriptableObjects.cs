using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "ScriptableObjects/TestScriptableObject")]
public class ScriptableObjects : ScriptableObject
{
    public string postName;
    public Sprite postImage;
    public string username;
    public string likes;
    
}

