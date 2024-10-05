using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngineInternal;


public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float Speed;
    public Rigidbody2D playerRb;
    public float jumpForce;
    public bool isOnGround;
    public bool gameOver;
    
    public GameObject orc;
    
    


    public Animator playerAnimator; 
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput, 0, 0) * Speed * Time.deltaTime;
        playerAnimator.SetFloat("Speed_f", Mathf.Abs(horizontalInput));
        if (Input.GetKey(KeyCode.Space)&& Mathf.Abs(playerRb.velocity.y)<=0.001f )
        {
            playerRb.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
            playerAnimator.SetBool("Jump",true);
        }

        if (playerRb.velocity.y < 0)
        {
            playerAnimator.SetBool("Jump", false);
            playerAnimator.SetBool("Fall", true);
        }

        if (Mathf.Abs(playerRb.velocity.y) <= 0.001f)
        {
            playerAnimator.SetBool("Fall", false);
        }
            if (!Mathf.Approximately(0, horizontalInput))
        {
            transform.rotation = horizontalInput > 0 ? Quaternion.identity : Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        if (other.gameObject.CompareTag("obstacle"))
        {
            gameOver = true;
            SceneManager.LoadScene("Menu");
        }
        if (other.gameObject.CompareTag("lvl2"))
        {
            gameOver = true;
            SceneManager.LoadScene("2lvl");
        }
        if (other.gameObject.CompareTag("WINN")) 
        {
            gameOver = true;
            SceneManager.LoadScene("3lvl");
        }
        if (other.gameObject.CompareTag("obs")) 
        {
            gameOver = true;
            SceneManager.LoadScene("4lvl");
        }
        if (other.gameObject.CompareTag("force")) 
        {
            gameOver = true;
            SceneManager.LoadScene("win");
        }
        if (other.gameObject.CompareTag("vragi"))
        {
            Destroy(orc, 1.5f);
        }

        




    }
}
