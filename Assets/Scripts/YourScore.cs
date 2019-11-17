﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class YourScore : MonoBehaviour
{
    public TextMeshProUGUI yourscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yourscore.text = PlayerController.Score.ToString();
    }  
    void SnowflakeRetry()
    {
        SceneManager.LoadScene(2);
    }
    void BoatRetry()
    {
        SceneManager.LoadScene(4);
    }

}
