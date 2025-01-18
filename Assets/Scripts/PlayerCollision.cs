using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public List<SimpleItem> inventory = new List<SimpleItem>();

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
                        i.Quantity += 1;
                        Debug.Log(i + " quantity updated to " + i.Quantity);
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

    public void RemoveItem(int itemNum)
    {
        inventory[itemNum].Quantity = 0;
        inventory.RemoveAt(itemNum);
    }
}
