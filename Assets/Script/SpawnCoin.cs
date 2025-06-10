using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject Bom;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float NextSpawnTime;

    
    void Update()
    {
        if(Time.time > NextSpawnTime)
        {
            Spawn();
            NextSpawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomY = UnityEngine.Random.Range(minY, maxY);

        Instantiate(Bom, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }


}