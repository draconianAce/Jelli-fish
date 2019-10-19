using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public GameManager player;
    public PlayerControls UIHealth;
    public TMP_Text HealthText;

    // Start is called before the first frame update
    void Awake()
    {

        //UIHealth = GetComponent<PlayerControls>();
        HealthText.text = "Health " + UIHealth.ToString();
        //GameManager.gameManager.health;
        //

    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health " + UIHealth.health.ToString();
        //GameManager.gameManager.health;
        //
    }


}
