using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Highscore : MonoBehaviour
{
    public TextMeshProUGUI highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController.Score = 0;
    }
}
