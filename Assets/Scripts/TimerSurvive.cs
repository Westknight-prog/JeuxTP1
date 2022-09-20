using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSurvive : MonoBehaviour
{
    Text Timer;
    float time;

    void Awake()
    {
        Timer = GetComponent<Text>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        PlayerPrefs.SetInt("Score", (int)time);
        Timer.text = "Score : "+ PlayerPrefs.GetInt("Score");
    }
}
