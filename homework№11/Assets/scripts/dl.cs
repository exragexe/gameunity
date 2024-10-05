using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    
    void Start()
    {
        text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(text, 1f);
    }
}
