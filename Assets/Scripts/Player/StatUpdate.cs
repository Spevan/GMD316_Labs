using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatUpdate : MonoBehaviour
{
    public PlayerStats PlayerStats;

    private void Start()
    {
        PlayerStats.Health = PlayerStats.BaseHealth;
        PlayerStats.Strength = PlayerStats.BaseStrength;
        PlayerStats.Agility = PlayerStats.BaseAgility;
        PlayerStats.Experience = PlayerStats.BaseExperience;
    }

    public void UpdateHealth(int healthDelta)
    {
        PlayerStats.Health += healthDelta;
    }

    public void UpdateStrength(int strengthDelta)
    {
        PlayerStats.Strength += strengthDelta;
    }

    public void UpdateAgility(int agilityDelta)
    {
        PlayerStats.Agility += agilityDelta;
    }

    public void UpdateExperience(int experienceDelta)
    {
        PlayerStats.Experience += experienceDelta;
    }
}
