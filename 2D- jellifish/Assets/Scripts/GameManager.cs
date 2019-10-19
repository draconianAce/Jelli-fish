using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public float ScrenWidth;
    public float ScreenHeight;
    public int health = 3;
    public bool isDead;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    private void Awake()
    {
        if(gameManager != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadScene()
    {
        
        SceneManager.LoadScene("SampleScene");//Enter the the scene you want to load
    }

    
}
