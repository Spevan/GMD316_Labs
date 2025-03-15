using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject PooledObj;
    public int PoolSize;
    public List<GameObject> PooledList;
    public float targetTime = 1.0f;

    public static ObjectPool Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }

        InitializePool(PooledObj, PoolSize);
    }

    private void Update()
    {
        for (int i = 0; i < PooledList.Count; i++)
        {
            if (targetTime <= 0.0f)
            {
                GetObjectFromPool(PooledList[i]);
                targetTime = 5.0f;
            }
        }
        targetTime -= Time.deltaTime;
    }

    public void InitializePool(GameObject pooledObj, int poolSize)
    {
        for (int i = 0; i < PoolSize; i++)
        {
            PooledList.Add(Instantiate(pooledObj));
            PooledList[i].SetActive(false);
        }
    }

    public GameObject GetObjectFromPool(GameObject pooledObj)
    {
        if(!pooledObj.activeSelf)
        {
            pooledObj.SetActive(true);
            return pooledObj;
        }
        else
        {
            PooledList.Add(Instantiate(PooledObj));
            return PooledList[PooledList.Count - 1];
        }
    }

    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
}
