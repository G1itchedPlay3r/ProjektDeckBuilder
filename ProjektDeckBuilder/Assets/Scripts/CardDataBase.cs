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
        cardList.Add(new Card(1, "Elf", 2, 1, "This is a Elf", Resources.Load<Sprite>("1"), "Green"));
        cardList.Add(new Card(2, "Dwarf", 3, 2, "This is a Dwarf", Resources.Load<Sprite>("2"), "Orange"));
        cardList.Add(new Card(3, "Human", 3, 1, "This is a Human", Resources.Load<Sprite>("3"), "Blue"));
       
        
        
        
        
        cardList.Add(new Card(4, "esen drain", 3, 10, "steal hp from the target", Resources.Load<Sprite>("4"), "Red"));
        cardList.Add(new Card(5, "hellfire", 1, 5, "deal damage ", Resources.Load<Sprite>("5"), "Red"));
        cardList.Add(new Card(6, "drain of power", 8, 1, "the target takes more dmg the next round", Resources.Load<Sprite>("6"), "Red"));
        cardList.Add(new Card(7, "demon charge", 4, 10, "charge  the target and deal  and weak them", Resources.Load<Sprite>("7"), "Red"));
        cardList.Add(new Card(8, "bottle of demon blood", 8, 10, "heal all demons on the playing field", Resources.Load<Sprite>("8"), "Red"));
        cardList.Add(new Card(9, "demonic portal", 5, 10, "Spawn 2 lesser imps that consistently attacks", Resources.Load<Sprite>("9"), "Red"));
        cardList.Add(new Card(10, "demonic possession", 7, 10, "halfs the effect of the target card for one turn", Resources.Load<Sprite>("10"), "Red"));
        cardList.Add(new Card(11, "Demon swipe", 8, 10, "Deal damage to target", Resources.Load<Sprite>("11"), "Red")); 
        cardList.Add(new Card(12, "Hellish rebuke", 5, 10, "Deal fire damage every time the target plays a card", Resources.Load<Sprite>("12"), "Red"));
        cardList.Add(new Card(13, "Devil bite", 5, 10, "deal damage to target", Resources.Load<Sprite>("13"), "Red"));
        cardList.Add(new Card(14, "Stunning screech", 5, 10, "The target loses 1 card from their hand", Resources.Load<Sprite>("14"), "Red"));
    }
}
