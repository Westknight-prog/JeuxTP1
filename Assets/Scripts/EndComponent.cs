using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndComponent : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(PlayerPrefs.GetInt("Score") >= 5)
        {
           SceneManager.LoadScene("EndScene");
        }
    }
}
