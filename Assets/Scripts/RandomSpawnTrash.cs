using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnTrash : MonoBehaviour
{
    public GameObject trash;
    float randX;
    float randY;
    public float SpawnRate = 2f;
    Vector2 WhereToSpawn;
    public float NextSpawn = 0.0f;
    public float MaxSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MaxSpawn <= 30)
        {
            if (Time.time > NextSpawn)
            {
                MaxSpawn += 1;
                NextSpawn = Time.time + SpawnRate;
                randX = Random.Range(-122f, 34f);
                randY = Random.Range(-48f, 80f);
                WhereToSpawn = new Vector2(randX, randY);
                Instantiate(trash, WhereToSpawn, Quaternion.identity);
            }
        }
        
    }
}
