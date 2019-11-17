using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        print(EskimoRB.rotation);
        //print(EskimoRB.position);
        if (Input.GetKey(KeyCode.W))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, -180);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement = Vector2.down * Speed;
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        transform.Translate(Movement * Time.deltaTime);
        Movement = Movement * 0.99f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.tag == "Island")
        {
            print("Works");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        


        print("Works");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);




    }
}

