using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public int TakingDmg;
    public GameManager gm;
    public TakingDMG DMG;

    public HealthPlayer healthbar;

    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TakingDmg = DMG.PlayerDMG;
        if (DMG.DMG == true)
        {
            TakeDamage(TakingDmg);
            DMG.DMG = false;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
