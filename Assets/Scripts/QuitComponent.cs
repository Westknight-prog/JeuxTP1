using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitComponent : MonoBehaviour
{
    public void OnClickQuit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
}
