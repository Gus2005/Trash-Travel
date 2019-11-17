using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnTrash : MonoBehaviour
{
    public GameObject trash, trashs, trashh, traash, trhuie;
    float randX;
    float randY;
    public float SpawnRate = 2f;
    Vector2 WhereToSpawn;
    public float NextSpawn = 0.0f;
    public float MaxSpawn = 0f;
    public float MaxMaxSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        MaxSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (MaxSpawn <= MaxMaxSpawn)
        {
            if (Time.time > NextSpawn)
            {
                MaxSpawn += 1;
                NextSpawn = Time.time + SpawnRate;
                randX = Random.Range(-130f, 60f);
                randY = Random.Range(-60f, 80f);
                WhereToSpawn = new Vector2(randX, randY);
                Instantiate(trash, WhereToSpawn, Quaternion.identity);
            }
        }
        if (MaxSpawn <= MaxMaxSpawn)
        {
            if (Time.time > NextSpawn)
            {
                MaxSpawn += 1;
                NextSpawn = Time.time + SpawnRate;
                randX = Random.Range(-130f, 60f);
                randY = Random.Range(-60f, 80f);
                WhereToSpawn = new Vector2(randX, randY);
                Instantiate(trashs, WhereToSpawn, Quaternion.identity);
            }
        }

    }
}
//Instantiate(trashs, WhereToSpawn, Quaternion.identity);
//Instantiate(trashh, WhereToSpawn, Quaternion.identity);
//Instantiate(traash, WhereToSpawn, Quaternion.identity);
//Instantiate(trhuie, WhereToSpawn, Quaternion.identity);