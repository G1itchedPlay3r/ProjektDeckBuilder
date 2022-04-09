using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDMG : MonoBehaviour
{
    public GameManager gm;

    public bool DMG;

    [Header("Enemy")]
    public int EnemymaxHealth = 100;
    public static int EnemycurrentHealth;
    public int EnemyTakingDmg;
    public int EnemyDMG = 1;

    [Header("Player")]
    public int PlayermaxHealth = 100;
    public static int PlayercurrentHealth;
    public int PlayerTakingDmg;
    public int PlayerDMG = 1;

    [Header("Healthbar")]
    public HealthPlayer Enemyhealthbar;
    public HealthPlayer Playerhealthbar;

    private void Awake()
    {
        PlayermaxHealth = 100;
        PlayercurrentHealth = PlayermaxHealth;
        Playerhealthbar.SetMaxHealth(PlayermaxHealth);

        EnemymaxHealth = 100;
        EnemycurrentHealth = EnemymaxHealth;
        Enemyhealthbar.SetMaxHealth(EnemymaxHealth);
    }
    private void Update()
    {
        if (gm.Attacking == true)
        {
            DMG = true;
        }

        PlayerTakeDamage(1);
        EnemyTakeDamage(1);
    }
    void PlayerTakeDamage(int damage)
    {
        if (DMG == true && gm.Attacking == true)
        {
            PlayercurrentHealth -= PlayerDMG;

            Playerhealthbar.SetHealth(PlayercurrentHealth);
        }
       
    }
    void EnemyTakeDamage(int damage)
    {
        if (DMG == true && gm.Attacking == true)
        {
            EnemycurrentHealth -= EnemyDMG;

            Enemyhealthbar.SetHealth(EnemycurrentHealth);
        }
    }
}
