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
    {
<<<<<<< HEAD
        print(EskimoRB.rotation);
        //print(EskimoRB.position);
=======
>>>>>>> 2c12dfac0daea342af1950b09f5653ea534deceb
        if (Input.GetKey(KeyCode.W))
        {
            Movement = Vector2.up * Speed;
            //BoatRB.AddForce(Speed * ForwardDirection);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement = Vector2.down * Speed;
<<<<<<< HEAD
            transform.eulerAngles = Vector3.down * -180;
            //BoatRB.AddForce(Speed * BackDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, 90);
=======
            //             BoatRB.AddForce(Speed * BackDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.right * Speed;
>>>>>>> 2c12dfac0daea342af1950b09f5653ea534deceb
            //BoatRB.AddForce(HorizontalSpeed * RightDirection);
        }
        if (Input.GetKey(KeyCode.A))
        {
<<<<<<< HEAD
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, -90); 
=======
            Movement = Vector2.left * Speed;
>>>>>>> 2c12dfac0daea342af1950b09f5653ea534deceb
            //BoatRB.AddForce(HorizontalSpeed * LeftDirection);
        }
        transform.Translate(Movement * Time.deltaTime);
        Movement = Movement * 0.99f;
        
    }
}
