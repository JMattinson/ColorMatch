using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class RestartBehavior : MonoBehaviour
{
    
    
    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
