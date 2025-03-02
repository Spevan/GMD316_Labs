using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    int highlightedTab;
    public List<SimpleItem> inventory;
    public PlayerController player;

    public GameObject[] tab;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = PlayerController.Instance;
        }
        inventory = GameObject.Find("Player").GetComponent<PlayerCollision>().inventory;
        Debug.Log(inventory);
        int count = 0;
        foreach (SimpleItem i in inventory)
        {
            for(int x = 0; x <= 2; x++)
            {
                tab[count].SetActive(true);
                switch(x)
                {
                    case 0:
                        tab[count].transform.GetChild(x).GetComponent<TextMeshProUGUI>().text = i.name;
                        break;
                    case 1:
                        tab[count].transform.GetChild(x).GetComponent<TextMeshProUGUI>().text = i.Description;
                        break;
                    case 2:
                        tab[count].transform.GetChild(x).GetComponent<TextMeshProUGUI>().text = i.Quantity.ToString();
                        break;
                }
            }
            //tab[count].GetComponentInChildren<TextMeshProUGUI>().text = i.name;
            ++count;
        }
    }

    public void HighlightItem(GameObject highlight)
    {
        int count = 0;
        foreach(GameObject tab in tab)
        {
            if (highlight.Equals(tab))
            {
                highlightedTab = count;
                break;
            }
            count++;
        }
    }

    public void UseItem()
    {
        if (player.player.Health < 100 && inventory[highlightedTab].DmgOrHealing > 0)
        {
            player.player.Health += inventory[highlightedTab].DmgOrHealing;
            RemoveItem();
            this.GetComponent<CharNames>().UpdateCharHealth((int)player.player.Health);
        }
        else if (player.player.Health > 0 && inventory[highlightedTab].DmgOrHealing < 0)
        {
            player.player.Health += inventory[highlightedTab].DmgOrHealing;
            this.GetComponent<CharNames>().UpdateCharHealth((int)player.player.Health);
            player.player.EXP++;
            if (player.player.EXP == 10)
            {
                player.player.LVL++;
                player.player.AtkPower += 5;
                player.player.Speed++;
                player.player.Mana++;
                player.player.Health = 110;
                player.player.EXP = 0;
            }
        }
    }

    public void RemoveItem()
    {
        if(player.GetComponent<PlayerCollision>().RemoveItem(highlightedTab) == 0)
        {
            tab[highlightedTab].SetActive(false);
        }
    }
}
