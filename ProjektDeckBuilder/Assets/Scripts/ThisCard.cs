    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ThisCard : MonoBehaviour
{
    
    public List<Card> thisCard = new List<Card>();
    public List<Card> displayCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDes;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI descriptionText;

    public Sprite thisSprite;
    public Image thatImage;
    public Image frame;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.decksize;

        thisId = Random.Range(4, 13);

        thisCard[0] = CardDataBase.cardList[thisId];

    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.Find("Hand");

        if (this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }
        if (this.tag == "Clone")
        {
            //displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            PlayerDeck.decksize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }

        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        cost = thisCard[0].cost;
        power = thisCard[0].power;
        cardDes = thisCard[0].cardDes;

        thisSprite = thisCard[0].thisImage;
        nameText.text = "" + cardName;
        costText.text = "" + cost;
        powerText.text = "" + power;
        descriptionText.text = "" + cardDes;

        thatImage.sprite = thisSprite;

        if (thisCard[0].color == "Red")
        {
            frame.GetComponent<Image>().color = new Color32(255,0,0,255);
        }
        if (thisCard[0].color == "Blue")
        {
            frame.GetComponent<Image>().color = new Color32(0, 0, 255, 255);
        }
        if (thisCard[0].color == "Orange")
        {
            frame.GetComponent<Image>().color = new Color32(255, 100, 0, 255);
        }
        if (thisCard[0].color == "Green")
        {
            frame.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
        }

        staticCardBack = cardBack;
    }
}
