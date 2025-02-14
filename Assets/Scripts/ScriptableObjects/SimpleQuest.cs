using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Scriptable Sheets/SimpleQuest")]
public class SimpleQuest : ScriptableObject
{
    public string QuestName;
    public List<string> Objectives;
    public int Reward;
}
