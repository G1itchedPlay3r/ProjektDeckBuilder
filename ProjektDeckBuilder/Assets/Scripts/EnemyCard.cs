using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCard : MonoBehaviour
{
    public GameObject enemyCard;
    public GameManager gm;
    public TakingDMG DMG;
    public Transform Discard;
    public Transform enemyPlay;
    public bool Attacking;
    public static int damage;
    public CardFill Strength;

    private void FixedUpdate()
    {
        damage = enemyCard.GetComponentInChildren<CardFill>().damage;
    }

    void Update()
    {

        if (gm.Attacking == true)
        {
            enemyCard.SetActive(true);
            Attacking = true;
            enemyCard.transform.position = enemyPlay.position;
            Invoke("MoveToEnemyDiscardPile", 5f);
            DMG.EnemyDMG = damage;
            gm.Attacking = false;
        }
    }

    void MoveToEnemyDiscardPile()
    {
        gm.enemyDiscard.Add(enemyCard);

        enemyCard.transform.position = Discard.position;
    }
}
