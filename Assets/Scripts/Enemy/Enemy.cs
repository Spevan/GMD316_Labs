using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SimpleEnemy enemyData;

    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Player").transform.position, Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            ObjectPool.Instance.ReturnObjectToPool(this.gameObject);
            Debug.Log(enemyData.Name + ", " + enemyData.Health + ", " + enemyData.AtkPower + ", " + enemyData.Speed);
        }
    }
}
