using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Sheets/Simple Item")]
public class SimpleItem : ScriptableObject
{
    public string Name;
    public string Description;
    public bool Stackable;
    public int Quantity, MaxStackSize;
    public Sprite Icon;
}
