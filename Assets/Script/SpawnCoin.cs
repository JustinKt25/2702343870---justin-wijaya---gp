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
            spawn();
            NextSpawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(Coin, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}

