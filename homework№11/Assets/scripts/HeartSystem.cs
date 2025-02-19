﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public static int health;
    public GameObject Heart1, Heart2, Heart3;
    void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(true);
        Heart3.SetActive(true);
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        switch (health)
        {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;
            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;
            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
            case 0:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                SceneManager.LoadScene("Menu");
                break;
        }
        
    }
}
