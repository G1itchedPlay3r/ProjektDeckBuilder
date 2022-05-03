using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDes;

    public Sprite thisImage;

    public string color;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDesprition, Sprite ThisImage, string Color)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDes = CardDesprition;

        thisImage = ThisImage;

        color = Color;
    }
}
