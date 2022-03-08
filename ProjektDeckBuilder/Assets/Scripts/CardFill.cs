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

    [Header("Extra")]

    private GameManager gm;
    public int handIndex;
    public bool hasBeenPlayed;
    public Transform Play;
    public Transform Discard;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        
        Camera worldCamera = canvas.GetComponent<Canvas>().worldCamera; 
        
        ImageTemplate.GetComponent<SpriteRenderer>().sprite = cardObj.CardImage;
        BackGround.GetComponent<SpriteRenderer>().sprite = cardObj.CardBackGround;
        Description.GetComponent<TextMeshProUGUI>().text = cardObj.Description;
        DamageAndHealth.GetComponent<TextMeshProUGUI>().text = cardObj.Strength.ToString();
        Name.GetComponent<TextMeshProUGUI>().text = cardObj.Name;
        Cost.GetComponent<TextMeshProUGUI>().text = cardObj.Cost.ToString() + " Mana";
    }

    private void OnMouseDown()
    {
        if (hasBeenPlayed == false)
        {
            BackGround.transform.position = Play.position;
            hasBeenPlayed = true;
            gm.avialiableCardSlots[handIndex] = true;
            Invoke("MoveToDiscardPile", 5f);
        }
    }

    void MoveToDiscardPile()
    {
        gm.discardPile.Add(BackGround);
        BackGround.SetActive(false);

        BackGround.transform.position = Discard.position;
    }
}
