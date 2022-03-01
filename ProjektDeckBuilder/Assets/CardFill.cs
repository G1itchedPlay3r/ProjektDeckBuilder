using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardFill : MonoBehaviour
{
    public CardsObject cardObj;
    public GameObject ImageTemplate;
    public GameObject BackGround;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI DamageAndHealth;
    public TextMeshProUGUI Cost;
    public TextMeshProUGUI Name;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        Camera worldCamera = canvas.GetComponent<Canvas>().worldCamera; 
        
        ImageTemplate.GetComponent<SpriteRenderer>().sprite = cardObj.CardImage;
        BackGround.GetComponent<SpriteRenderer>().sprite = cardObj.CardBackGround;
        Description.GetComponent<TextMeshProUGUI>().text = cardObj.Description;
        DamageAndHealth.GetComponent<TextMeshProUGUI>().text = cardObj.Strength.ToString() + " / " + cardObj.Health.ToString();
        Name.GetComponent<TextMeshProUGUI>().text = cardObj.Name;
        Cost.GetComponent<TextMeshProUGUI>().text = cardObj.Cost.ToString() + " Mana";
    }
}
