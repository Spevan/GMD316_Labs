using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestNames : MonoBehaviour
{
    public TextMeshProUGUI QuestName;
    public List<TextMeshProUGUI> QuestObjectives;

    private void Awake()
    {
        UpdateQuest(PlayerController.Instance.quest.QuestName);
        UpdateObjectives(PlayerController.Instance.quest.Objectives[0], PlayerController.Instance.quest.Objectives[1]);
    }

    public void UpdateQuest(string name)
    {
        QuestName.text = name;
    }

    public void UpdateObjectives(string obj1, string obj2)
    {
        QuestObjectives[0].text = obj1;
        QuestObjectives[1].text = obj2;
    }
}
