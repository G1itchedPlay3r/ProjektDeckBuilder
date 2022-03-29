using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCard : MonoBehaviour
{
    public GameManager gm;
    public TakingDMG DMG;
    public static int damage;
    public GameObject card;

    private void FixedUpdate()
    {
        damage = card.GetComponentInChildren<CardFill>().damage;
    }
    void Update()
    {
        if (gm.Attacking == true)
        {
            DMG.PlayerDMG = damage;

            gm.Attacking = false;
        }
    }
}
