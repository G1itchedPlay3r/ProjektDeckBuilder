using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();
    public void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None", Resources.Load <Sprite>("0"), "None"));
        cardList.Add(new Card(1, "Elf", 2, 1, "None", Resources.Load<Sprite>("1"), "Green"));
        cardList.Add(new Card(2, "Dwarf", 3, 2, "None", Resources.Load<Sprite>("2"), "Orange"));
        cardList.Add(new Card(3, "Human", 3, 1, "None", Resources.Load<Sprite>("3"), "Blue"));
        cardList.Add(new Card(4, "Demon", 5, 10, "None", Resources.Load<Sprite>("4"), "Red"));
    }
}
