using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{



    public GameObject BubbleEffect;
    
    //variable that stores the the reansformation of the player
    private Vector2 playerPos;

    //variable to store the movemoent incrementation viewed on the editor(this is thrust)
    public int p_increment;

    //variable the defines the height of the thats the player can go in the y-axis
    public int max_Height;

    //variable of the speed the player movestoward the different play pos
    private int p_speed;

    //varible for health of the player
    public int health;

    //variable to store the rigidbody
    public Rigidbody2D rb;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
        if (health <= 0)
        {
            SceneManager.LoadScene("ExitScene");
        }

    }

    private void Move()
    {
        //making the transition between movemonet more smoothly
        transform.position = Vector2.MoveTowards(transform.position, playerPos, p_speed * Time.deltaTime);

        

            if (transform.position.y < max_Height && transform.position.y > -max_Height)
            {

            if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                Debug.Log("helo");
                rb.AddForce(transform.up * p_increment);
                Instantiate(BubbleEffect, transform.position, Quaternion.identity);
            }
                

            }
    }

    void checkHealth()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("ExitScene");
        }
    }

    
}
