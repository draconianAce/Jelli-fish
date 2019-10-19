using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPlanktons : MonoBehaviour
{
    public GameObject[] ObstacleList;//A list containing the obstacles spawn
    public int heal = 1;//the heal dealth when something collide with it
    public float max_SpawnSpeed;//this is the max speed the obstacle can spawn
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //this lloks at the collision with something that has a player tag
        if (collision.CompareTag("Player"))
        {
            //this gets the component healt in the player controls and subtract damage
            collision.GetComponent<PlayerControls>().health += heal;
            //this will destroy this game object
            Destroy(gameObject);
        }
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform the game object in a vector2 using the unity engine to the left by time by deltatime
        transform.Translate(Vector2.left*Time.deltaTime);
    }

    private void Update()
    {
        
    }

}
