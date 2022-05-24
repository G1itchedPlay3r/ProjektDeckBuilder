using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int isOppenetTurn;
    public TextMeshProUGUI turnText;

    public int MaxMana;
    public int currentMana;
    public TextMeshProUGUI manaText;

    public static bool startTurn;

    // Start is called before the first frame update
    void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        isOppenetTurn = 0;

        MaxMana = 1;
        currentMana = 1;

        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isYourTurn == true)
        {
            turnText.text = "Your Turn";
        }
        else
        {
            turnText.text = "Oppenent Turn";
        }

        manaText.text = currentMana + "/" + MaxMana;
    }

    public void EndYourTurn()
    {
        isYourTurn = false;
        isOppenetTurn += 1;
    }

    public void EndOppenentTurn()
    {
        isYourTurn = true;
        isOppenetTurn -= 1;

        MaxMana += 1;
        currentMana = MaxMana;

        startTurn = true;
    }
}
