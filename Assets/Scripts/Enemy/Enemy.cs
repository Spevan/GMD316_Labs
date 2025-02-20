using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SimpleEnemy enemyData;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log(enemyData.Name + ", " + enemyData.Health + ", " + enemyData.AtkPower + ", " + enemyData.Speed);
        }
    }
}
