using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int health = 0;
    public int maxHealth = 3;
    public TMP_Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        SetHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TakeDamage()
    {
        SetHealth(health - 1);
    }

    public void SetHealth(int newHealth)
    { 
        health = newHealth;
        healthText.text = "HP: " + health;
        if (health <= 0)
        {
            SceneManager.LoadScene("Game_Over");
        }
    }
}
