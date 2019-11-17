using System.Collections;
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
<<<<<<< HEAD
    {
<<<<<<< HEAD
        //print(EskimoRB.rotation);
        print(EskimoRB.position);
=======
<<<<<<< HEAD
        print(EskimoRB.rotation);
        //print(EskimoRB.position);
=======
>>>>>>> 2c12dfac0daea342af1950b09f5653ea534deceb
>>>>>>> 60584bccf4000194142ad64c949f49a012151dae
        if (Input.GetKey(KeyCode.W))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = Vector3.forward * 180;
            //BoatRB.AddForce(Speed * ForwardDirection);
=======
    { 

        print(EskimoRB.rotation);
        //print(EskimoRB.position);
        if (Input.GetKey(KeyCode.W))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, -180);
>>>>>>> 2f96efa9ed9681c7d7381988bc6cf8e88f54476a
        }
        if (Input.GetKey(KeyCode.S))
        {
<<<<<<< HEAD
            Movement = Vector2.up * Speed;
            transform.eulerAngles = Vector3.down * -180;
            //BoatRB.AddForce(Speed * BackDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.left * Speed;
            transform.eulerAngles = Vector3.right * 90;
=======
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, 90);
<<<<<<< HEAD
=======
            //             BoatRB.AddForce(Speed * BackDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.right * Speed;
>>>>>>> 2c12dfac0daea342af1950b09f5653ea534deceb
>>>>>>> 60584bccf4000194142ad64c949f49a012151dae
            //BoatRB.AddForce(HorizontalSpeed * RightDirection);
        }
        if (Input.GetKey(KeyCode.A))
        {
<<<<<<< HEAD
            Movement = Vector2.right * Speed;
            transform.eulerAngles = Vector3.left * -90;
=======
<<<<<<< HEAD
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, -90); 
=======
            Movement = Vector2.left * Speed;
>>>>>>> 2c12dfac0daea342af1950b09f5653ea534deceb
>>>>>>> 60584bccf4000194142ad64c949f49a012151dae
            //BoatRB.AddForce(HorizontalSpeed * LeftDirection);
=======
        }
        if (Input.GetKey(KeyCode.A))
        { 
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, -90);
>>>>>>> 2f96efa9ed9681c7d7381988bc6cf8e88f54476a
        }
        transform.Translate(Movement * Time.deltaTime);
        Movement = Movement * 0.99f;
    }
}
