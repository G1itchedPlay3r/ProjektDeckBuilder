using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCard : MonoBehaviour
{
    public GameObject enemyCard;
    public GameManager gm;
    public Transform Discard;
    public Transform enemyPlay;
    public bool Attacking;
    public static int damage;
    public CardFill Strength;

    // Update is called once per frame
    void Update()
    {
        damage += enemyCard.GetComponentInChildren<CardFill>().damage;

        if (gm.Attacking == true)
        {
            enemyCard.SetActive(true);
            Attacking = true;
            enemyCard.transform.position = enemyPlay.position;
            Invoke("MoveToEnemyDiscardPile", 5f);
            gm.Attacking = false;
        }
    }

    void MoveToEnemyDiscardPile()
    {
        gm.enemyDiscard.Add(enemyCard);

        enemyCard.transform.position = Discard.position;
    }
}
