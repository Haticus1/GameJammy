using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Pool;

public class PlayerObjectPool : MonoBehaviour
{
    public static PlayerObjectPool instance;
    public GameObject objectToSpawn;
    public List<GameObject> poolOfObjects;

    public int poolCount = 20;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        poolOfObjects = new List<GameObject>();
        for(int i = 0; i < poolCount; i++)
        {
            GameObject obj = Instantiate(objectToSpawn);
            obj.SetActive(false);
            poolOfObjects.Add(obj);
        }
    }

    public GameObject GetPoolObject()
    {
        for (int i = 0; i < poolOfObjects.Count; i++)
        {
            if (!poolOfObjects[i].activeInHierarchy)
            {
                return poolOfObjects[i];
            }
        }
        return null;
        
    }

}
