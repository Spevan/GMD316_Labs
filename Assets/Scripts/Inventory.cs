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

    public GameObject[] tab;

    // Update is called once per frame
    void Update()
    {
        inventory = GameObject.Find("Player").GetComponent<PlayerCollision>().inventory;
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

    public void RemoveItem()
    {
        tab[highlightedTab].SetActive(false);
        GameObject.Find("Player").GetComponent<PlayerCollision>().RemoveItem(highlightedTab);
    }
}
