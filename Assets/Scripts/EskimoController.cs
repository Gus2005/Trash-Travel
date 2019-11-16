﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EskimoController : MonoBehaviour
{
    public Rigidbody2D EskimoRB;
    public int Speed;
    public int HorizontalSpeed;
    public Vector2 Movement;
    public Vector2 ForwardDirection;
    public Vector2 BackDirection;
    public Vector2 RightDirection;
    public Vector2 LeftDirection;
    public static int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement = Vector2.up * Speed;
            //BoatRB.AddForce(Speed * ForwardDirection);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement = Vector2.down * Speed;
            //             BoatRB.AddForce(Speed * BackDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.right * Speed;
            //BoatRB.AddForce(HorizontalSpeed * RightDirection);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement = Vector2.left * Speed;
            //BoatRB.AddForce(HorizontalSpeed * LeftDirection);
        }
        transform.Translate(Movement * Time.deltaTime);
        Movement = Movement * 0.99f;
    }
}