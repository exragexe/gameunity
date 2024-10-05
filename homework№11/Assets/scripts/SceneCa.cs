using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCa : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene ("2lvl");
        
    }
    
   
   
    public void Exit()
    {
        Application.Quit ();
    }
}