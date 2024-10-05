using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogr : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedBoost;
    [SerializeField] private float distanceAngry;
    [SerializeField] private float distancePatrol;
    private float minDistance;
    private float maxDistance;
    private Animator anim; 
    //private Rigidbody2D rb;
    private bool patrol=true;
    private GameObject player;
    public GameObject faas;

    private void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
       // rb = GetComponent<Rigidbody2D>();
        minDistance = transform.position.x - distancePatrol;
        maxDistance = transform.position.x + distancePatrol;
    }

    private void Update()
    {
        if (patrol == true)
            Patrol();
        if (Input.GetKeyDown(KeyCode.Mouse0))
            anim.SetTrigger("run");
        
        // else
        //    Angry();
        //if (Vector2.Distance(transform.position, player.transform.position) < distancePatrol)
        //{
        //    Mathf.Abs(speed);
        //   patrol = false;
        // }
       
    }

   
    

    private void Patrol()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
        if (transform.position.x > maxDistance)
        {
            speed = -speed;
            transform.rotation = Quaternion.Euler(0,180,0);
        }
       if (transform.position.x < minDistance)
        {
            speed = -speed;
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }

   // private void Angry()
   // {
   //     if (patrol == false)
    //    {
    //        Vector2 moveVector = Vector2.MoveTowards(transform.position, player.transform.position,
    //            speedBoost * speed * Time.deltaTime);
    //        transform.position = new Vector2(moveVector.x, transform.position.y);
    ////        if (transform.position.x > player.transform.position.x) ;
     //       {
     //           transform.rotation = Quaternion.Euler(0,180,0);
     //       }
     //       if (transform.position.x < player.transform.position.y){
    //transform.rotation = Quaternion.Euler(0,0,0);
       //     }
      //  }
    //}
}
