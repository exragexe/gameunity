using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class play : MonoBehaviour
{
    public GameObject GameObject;
    
    


    public void Start()
    {
        
        

    }

    public void OnPause()
        {

            Time.timeScale = 0;
            GameObject.SetActive(true);
            
        }

    public void OnResume()
    {

        Time.timeScale = 1f; 
        GameObject.SetActive(false);
        

    }
    



}