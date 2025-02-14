using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharNames : MonoBehaviour
{
    public TextMeshProUGUI charName, charHealth;

    private void Awake()
    {
        UpdateCharName(PlayerController.Instance.player.Name);
        UpdateCharHealth(PlayerController.Instance.player.Health);
    }

    public void UpdateCharName(string name)
    {
        charName.text = name;
    }

    public void UpdateCharHealth(int health)
    {
        charHealth.text = health.ToString();
    }
}
