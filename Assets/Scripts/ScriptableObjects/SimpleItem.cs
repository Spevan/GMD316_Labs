using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Sheets/Simple Item")]
public class SimpleItem : ScriptableObject
{
    public string Name;
    public string Description;
    public bool Stackable;
    public ItemType type;
    public enum ItemType
    {
        Weapon,
        Potion,
        Crafting_Material
    }
    public int Quantity, MaxStackSize, DmgOrHealing;
    public Rarity rarity;
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Legendary
    }
    public Sprite Icon;
}
