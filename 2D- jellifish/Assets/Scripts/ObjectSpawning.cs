using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawning : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject Player;

    private float spawnInterval;//this is the interval of which the object wait for to spawn the next
    public float spawnTime;//time of which the object spawn
    public float decreaseSpawnTime;//decrease time between spawn
    public float minTime;//minimum time between spawn
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnInterval <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            spawnInterval = spawnTime;
            if(spawnTime > minTime)
            {
                spawnTime -= decreaseSpawnTime;
            }
        }
        else
        {
            spawnInterval -= Time.deltaTime;

        }
    }
}
