
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewInfoObject", menuName = "ScriptableObjects/InfoObject", order = 1)]

public class InfoScriptable : ScriptableObject
{
    public string title;
     [TextArea(12, 40)]
    public string info;
    public Sprite image;
}
