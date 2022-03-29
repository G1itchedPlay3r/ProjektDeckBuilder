using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public int TakingDmg;
    public GameManager gm;
    public TakingDMG DMG;

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
        TakingDmg = DMG.EnemyDMG;
        if (DMG.DMG == true)
        {
            TakeDamage(TakingDmg);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
