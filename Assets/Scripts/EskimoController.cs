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
        //print(EskimoRB.rotation);
        print(EskimoRB.position);

        print(EskimoRB.rotation);
        //print(EskimoRB.position);


        if (Input.GetKey(KeyCode.W))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = Vector3.forward * 180;
            //BoatRB.AddForce(Speed * ForwardDirection);

            {

                print(EskimoRB.rotation);
                //print(EskimoRB.position);
                if (Input.GetKey(KeyCode.W))
                {
                    Movement = Vector2.down * Speed;
                    transform.eulerAngles = new Vector3(0, 0, -180);

                }
                if (Input.GetKey(KeyCode.S))
                {

                    Movement = Vector2.up * Speed;
                    transform.eulerAngles = Vector3.down * -180;
                    //BoatRB.AddForce(Speed * BackDirection);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    Movement = Vector2.left * Speed;
                    transform.eulerAngles = Vector3.right * 90;

                    Movement = Vector2.down * Speed;
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    Movement = Vector2.down * Speed;
                    transform.eulerAngles = new Vector3(0, 0, 90);

                    //             BoatRB.AddForce(Speed * BackDirection);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    Movement = Vector2.right * Speed;
                    //BoatRB.AddForce(HorizontalSpeed * RightDirection);
                }
                if (Input.GetKey(KeyCode.A))
                {

                    Movement = Vector2.right * Speed;
                    transform.eulerAngles = Vector3.left * -90;


                    Movement = Vector2.down * Speed;
                    transform.eulerAngles = new Vector3(0, 0, -90);

                    Movement = Vector2.left * Speed;


                    //BoatRB.AddForce(HorizontalSpeed * LeftDirection);

                }
                if (Input.GetKey(KeyCode.A))
                {
                    Movement = Vector2.down * Speed;
                    transform.eulerAngles = new Vector3(0, 0, -90);

                }
                transform.Translate(Movement * Time.deltaTime);
                Movement = Movement * 0.99f;
            }
        }
    }
      