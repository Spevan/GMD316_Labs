using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public List<string> skills;

    public GameObject[] tab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skills = PlayerController.Instance.player.Skills;
        int count = 0;
        foreach (string i in skills)
        {
            tab[count].SetActive(true);
            tab[count].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = i;
            ++count;
        }
    }
}
