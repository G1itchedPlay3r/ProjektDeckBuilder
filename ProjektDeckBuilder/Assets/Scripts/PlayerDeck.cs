using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> Deck = new List<Card>();
    public List<Card> container = new List<Card>();

    public int x;
    public int decksize;

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        for (int i = 0; i < 40; i++)
        {
            x = Random.Range(1, 4);
            Deck[i] = CardDataBase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (decksize < 30)
        {
            cardInDeck1.SetActive(false);
        }
        if (decksize < 15)
        {
            cardInDeck2.SetActive(false);
        }
        if (decksize < 2)
        {
            cardInDeck3.SetActive(false);
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < decksize; i++)
        {
            container[0] = Deck[i];
            int randomIndex = Random.Range(i, decksize);
            Deck[randomIndex] = container[0];
        }
    }
}
