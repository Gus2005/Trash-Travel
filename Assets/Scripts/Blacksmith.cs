﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : MonoBehaviour {
    public GameObject boat;
    float randX;
    float randY;
    Vector2 WhereToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyBoat()
    {
        randX = (0);
        randY = (0);
        WhereToSpawn = new Vector2(randX, randY);
        Instantiate(boat, WhereToSpawn, Quaternion.identity);
    }

}