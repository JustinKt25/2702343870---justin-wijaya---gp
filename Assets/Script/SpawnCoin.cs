using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject Coin;
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
        if(Coin == null)
        {
            Debug.LogWarning("Prefab Coin belum di-assign di Inspector!");
            return;
        }

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new(randomX, randomY, 0f);
        Instantiate(Coin, spawnPos, Quaternion.identity);

        Debug.Log("Coin spawned at: " + spawnPos);
    }
}

