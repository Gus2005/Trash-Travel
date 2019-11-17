using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (PlayerController.Score >= 25)
        {
            SceneManager.LoadScene(4);
        }
        
    }

}
