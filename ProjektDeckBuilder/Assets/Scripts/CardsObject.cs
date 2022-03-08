using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card", menuName = "Cards")]

public class CardsObject : ScriptableObject
{
    public Sprite CardImage;
    public Sprite CardBackGround;
    public int Strength;
    public int Cost;
    public string Description;
    public string Name;
}
