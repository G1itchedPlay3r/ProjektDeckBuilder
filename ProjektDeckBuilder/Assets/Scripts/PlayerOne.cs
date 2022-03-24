using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;

    public HealthPlayer healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameManager.Damage == true)
        {
            TakeDamage(GameManager.EnemyDamage);
            GameManager.Damage = false;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
