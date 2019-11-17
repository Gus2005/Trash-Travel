﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI countdown;
    static public int timeleft = 127;
    public TextMeshProUGUI ScoreText;   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = PlayerController.Score.ToString();
        countdown.text = ("" + timeleft);

        if (timeleft <= 0)
        {
            PlayerController.Score = 0;
            SceneManager.LoadScene(4);
        }
        
    }
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeleft--;
        }
    }
}
