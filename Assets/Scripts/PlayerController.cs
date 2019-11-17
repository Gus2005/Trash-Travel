using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D BoatRB;
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
        //print(BoatRB.position);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Island")
        {
            if (Score>= 25)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                BoatRB.AddForce(Vector2)
            }

        }
        //else if(collision.gameObject.name == "Oven")


<<<<<<< HEAD




        {
            SceneManager.LoadScene("Blacksmith");

        }
=======
       
>>>>>>> 6f8b1d1c672da9ce0716422e60b2871f50008b31

    }

    public AudioSource CollectSound;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Trash")
        {
            PlayerController.Score += 1;
            Destroy(col.gameObject);
            CollectSound.Play();
        }
    }
} 
            
    


    

