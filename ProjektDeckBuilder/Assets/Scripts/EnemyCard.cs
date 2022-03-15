using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCard : MonoBehaviour
{
    public GameObject enemyCard;
    public GameManager gm;
    public Transform Discard;
    public Transform enemyPlay;

    // Update is called once per frame
    void Update()
    {
        if (gm.Attacking == true)
        {
            enemyCard.SetActive(true);
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
