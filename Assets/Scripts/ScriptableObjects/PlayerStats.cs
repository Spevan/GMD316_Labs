using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Sheets/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public int Health, BaseHealth = 100, MaxHealth = 100, Strength, BaseStrength = 1, Agility, BaseAgility = 1;
    public float Experience, BaseExperience = 0;
}
