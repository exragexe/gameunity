using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    public GameObject player;
    
    public float StartDelay;
    public float RepeatDelayl;
    
    
    void Start()
    {
        InvokeRepeating("CreateObstacle",RepeatDelayl,RepeatDelayl);
    }

    // Update is called once per frame
   private void CreateObstacle()
   {
      
       Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
   }

   

}