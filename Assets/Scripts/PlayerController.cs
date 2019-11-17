using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D BoatRB;
    public TextMeshProUGUI getscoretext;
    public TextMeshProUGUI gettoisland;
    public int Speed;
    public Vector2 gettoislandnow;
    public Vector2 Movement;
    public Vector2 ForwardDirection;
    public Vector2 BackDirection;   
    public Vector2 RightDirection;
    public Vector2 LeftDirection;
    public static int Score;
    public static int mission;
    public TextMeshProUGUI missiontext;
    // Start is called before the first frame update
    void Start()
    {
        gettoisland.transform.position = new Vector2(-193, -500);
        mission = 25;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);

        }
        print(BoatRB.position);
      
        missiontext.text = mission.ToString();
  
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
        if (mission <= 0)
        {
            Destroy(getscoretext);
            Destroy(missiontext);
            gettoisland.transform.position = gettoislandnow;
        }
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

                //BoatRB.AddForce(Vector2);

            }

        }

        else if(collision.gameObject.name == "Oven")

        //else if(collision.gameObject.name == "Oven")





        {
            SceneManager.LoadScene("Blacksmith");

        }

       


    }

    public AudioClip CollectSound;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Trash")
        {
            

            PlayerController.Score += 1;
            Destroy(col.gameObject);
            mission -= 1;
            
        }
        if (col.gameObject.tag == "Island")
        {
            if (Score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("Highscore", Score); 
            }
        }
    }
}



//var audioSource = GetComponents<AudioSource>()[1];
//audioSource.clip = CollectSound;
            //audioSource.Play();
    

