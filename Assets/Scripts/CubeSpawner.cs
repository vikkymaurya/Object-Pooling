using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    PoolSpawner poolSpawner;

    private void Start()
    {
        poolSpawner = PoolSpawner.Instance;
    }

    void FixedUpdate()
    {
        poolSpawner.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
