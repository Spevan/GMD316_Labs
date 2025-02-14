using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Scriptable Sheets/Simple Character")]
public class SimpleCharacter : ScriptableObject
{
    public string Name;
    public int Health;
    public float Speed;
    public List<string> Skills;
}
