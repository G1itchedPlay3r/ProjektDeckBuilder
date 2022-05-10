using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]

public class CardMaterial : ScriptableObject
{
    public new string name;
    public string description;
    public int manaCost;
    public int attack;
    
    
    public void print()
    {
        Debug.Log(name + "" + description + "The card cost" + manaCost);
    }
}
