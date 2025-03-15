using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharNames : MonoBehaviour
{
    public TextMeshProUGUI charName, charHealth;

    private void Update()
    {
        UpdateCharName(PlayerController.Instance.player.Name);
        UpdateCharHealth((int)PlayerController.Instance.stats.Health);
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
