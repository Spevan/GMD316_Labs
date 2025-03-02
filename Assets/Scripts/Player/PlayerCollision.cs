using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCollision : MonoBehaviour, IDataPersistence
{
    public List<SimpleItem> inventory = new List<SimpleItem>();

    public void LoadData(GameData data)
    {
        this.inventory = data.inventory;
    }

    public void SaveData(ref GameData data)
    {
        data.inventory = this.inventory;
    }

    private void Start()
    {
        Console.WriteLine("inv on");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Item"))
        {
            Debug.Log(inventory);
            if (inventory.Count > 0)
            {
                int count = 0;
                foreach (SimpleItem i in inventory.ToList())
                {
                    if (i.Equals(collision.gameObject.GetComponent<Item>().itemData))
                    {
                        if(i.Quantity < i.MaxStackSize && i.Stackable)
                        {
                            i.Quantity += 1;
                            Debug.Log(i + " quantity updated to " + i.Quantity);
                        }
                        break;
                    }
                    else if(count == inventory.Count - 1)
                    {
                        inventory.Add(collision.gameObject.GetComponent<Item>().itemData);
                        inventory[count + 1].Quantity = 1;
                        Debug.Log((count + 1) + "nd item");
                    }
                    count++;
                }
            }
            else
            {
                inventory.Add(collision.gameObject.GetComponent<Item>().itemData);
                inventory[0].Quantity = 1;
                Debug.Log("first item");
            }
            //inventory.Add(collision.gameObject.GetComponent<ScriptableObject>());
        }
    }

    public int RemoveItem(int itemNum)
    {
        inventory[itemNum].Quantity -= 1;
        if (inventory[itemNum].Quantity <= 0)
        {
            inventory.RemoveAt(itemNum);
            if (PlayerController.Instance.player.Health < 0)
            {
                return inventory[itemNum].Quantity;
            }
        }
        return 0;
    }
}
