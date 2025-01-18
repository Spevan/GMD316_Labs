using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOnOff : MonoBehaviour
{
    public GameObject[] menu;

    public void MenuOn()
    {
        foreach (GameObject i in menu)
        {
            i.SetActive(true);
        }    
    }

    public void MenuOff()
    {
        foreach (GameObject i in menu)
        {
            i.SetActive(false);
        }    
    }

    public void MenuChange()
    {
        foreach (GameObject i in menu)
        {
            if(i.activeSelf)
            {
                i.SetActive(false);
            }
            else
            {
                i.SetActive(true);
            }
        }
    }    
}
