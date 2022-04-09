using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private GameStates State;
    public static GameManager Instance;

    [Header("List")]
    public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> discardPile = new List<GameObject>();
    public List<GameObject> enemyDeck = new List<GameObject>();
    public List<GameObject> enemyDiscard = new List<GameObject>();
    
    [Header("Transform")]
    public Transform[] cardSlots;

    [Header("Text")]
    public TextMeshProUGUI PlHP;
    public TextMeshProUGUI EmHP;
    public TextMeshProUGUI Winner;
    public TextMeshProUGUI DeckSize;
    public TextMeshProUGUI DiscardPile;

    [Header("Bool")]
    public bool Playing = true;
    public bool Attacking = false;
    public bool[] avialiableCardSlots;

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            GameObject randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < avialiableCardSlots.Length; i++)
            {
                if (avialiableCardSlots[i] == true)
                {
                    randCard.SetActive(true);
                    Attacking = false;
                    //randCard.GetComponent<CardFill>().handIndex = i;

                    randCard.transform.position = cardSlots[i].position;
                    avialiableCardSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }

    public void EnemyDraw()
    {
        if (Attacking == true)
        {
            GameObject randEnemy = enemyDeck[Random.Range(enemyDeck.Count,enemyDeck.Count)];
            enemyDeck.Remove(randEnemy);
            return;
        }
    }
    
    public void Shuffle()
    {
        if (discardPile.Count >= 1)
        {
            foreach (GameObject card in discardPile)
            {
                deck.Add(card);
                
            }
            discardPile.Clear();
            foreach (GameObject enemyCard in enemyDiscard)
            {
                enemyDeck.Add(enemyCard);
            }
            discardPile.Clear();
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        State = GameStates.MainPhase;
        Winner.text = " ";
    }

    private void Update()
    {
        DeckSize.text = deck.Count.ToString();
        DiscardPile.text = discardPile.Count.ToString();

        PlHP.text = PlayerOne.currentHealth.ToString();
        EmHP.text = PlayerTwo.currentHealth.ToString();

        if (PlayerOne.currentHealth == 0)
        {
            Winner.text = "Player Won";
            Playing = false;
        }
        if (PlayerTwo.currentHealth == 0)
        {
            Winner.text = "Enemy Won";
            Playing = false;
        }
    }

    public void UpdateGameState(GameStates newState)
    {
        State = newState;
        switch (State)
        {
            case GameStates.DrawPhase:
                Debug.Log("Draw Your Card");
                break;
            case GameStates.MainPhase:
                Debug.Log("Play Your Cards");
                break;
            case GameStates.AttackPhase:
                Debug.Log("Chose Your Attacks");
                break;
            case GameStates.EndPhase:
                Debug.Log("Player Two Turn");
                break;
        }
    }

    public enum GameStates
    {
        DrawPhase,
        MainPhase,
        AttackPhase,
        EndPhase
    }
}
