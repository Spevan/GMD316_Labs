using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public List<SimpleItem> inventory;

    public GameData()
    {
        this.inventory = new List<SimpleItem>();
    }
}
