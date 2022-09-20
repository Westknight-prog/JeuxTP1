using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatchedComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "EnemySlim" || collision.gameObject.name == "EnemyFat")
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
