using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneC : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene ("SampleScene");
        
    }
    
   
   
    public void Exit()
    {
        Application.Quit ();
    }
}