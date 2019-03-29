using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance;
    public GameObject prefab;
    public float poolAmount;

    List<GameObject> bulletPools;
    bool newObject = true;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }else if(Instance !=this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        bulletPools = new List<GameObject>();
        for (int i = 0; i < poolAmount; i++)
        {
            GameObject temBullet = Instantiate(prefab) as GameObject;
            temBullet.SetActive(false);
            bulletPools.Add(temBullet);
        }
    }

    public GameObject ObjectFromPool()
    {
        for (int i = 0; i < bulletPools.Count; i++)
        {
            if(!bulletPools[i].activeInHierarchy)
            {
                return bulletPools[i];
            }
            
        }
        if (newObject)
        {
            GameObject temBullet = Instantiate(prefab) as GameObject;
            bulletPools.Add(temBullet);
            return temBullet;
        }

        return null;
    }
  
}
