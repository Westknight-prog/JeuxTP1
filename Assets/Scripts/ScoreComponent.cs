using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreComponent : MonoBehaviour
{
    Text Score;
    void Awake()
    {
        Score = GetComponent<Text>();
        Score.text = PlayerPrefs.GetInt("Score") > 0 ?  "Score : " + PlayerPrefs.GetInt("Score") : "Score : 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
