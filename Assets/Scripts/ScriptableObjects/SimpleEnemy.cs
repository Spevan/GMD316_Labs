using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Scriptable Sheets/Simple Enemy")]
public class SimpleEnemy : ScriptableObject
{
    public string Name;
    public int Health, AtkPower;
    public float Speed;
    public Weakness weakness;
    public enum Weakness
    {
        Fire,
        Water,
        Ice,
        Earth
    }
}
