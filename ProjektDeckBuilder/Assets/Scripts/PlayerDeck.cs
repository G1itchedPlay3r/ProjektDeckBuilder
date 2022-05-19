using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerDeck : MonoBehaviour {

    public List<Card> Deck = new List<Card>();
    public List<Card> container = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public int x;
    public static int decksize;
    public static int staticDeckSize;

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;

    public GameObject CardToHand;
    public GameObject[] Clone;
    public GameObject Hand;

    //public AudioClip audioSource;

    // Start is called before the first frame update
    void Start()
    {
        staticDeckSize = decksize;
        
        x = 1;
        decksize = 40;

        for (int i = 0; i < 40; i++)
        {
            x = Random.Range(1, 4);
            Deck[i] = CardDataBase.cardList[x];
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = Deck;
    
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
    IEnumerator StartGame()
    {
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(1);

            //audioSource.PlayOneShot(draw, 1f);

            var newCard  = Instantiate(CardToHand, transform.position, transform.rotation);
            newCard.transform.SetParent(Hand.transform);
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
