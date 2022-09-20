using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartComponent : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.SetInt("Score", 0); //Reset Score to 0
        SceneManager.LoadScene("Game"); 
    }
}
