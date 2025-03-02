using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Scriptable Sheets/Simple Character")]
public class SimpleCharacter : ScriptableObject
{
    public string Name;
    public int EXP, LVL;
    public float Health, Speed, Mana, AtkPower;
    public List<string> Skills;
}
