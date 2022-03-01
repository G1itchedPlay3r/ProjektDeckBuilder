using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTurn : MonoBehaviour
{
    private int State;
    private int Round = 1;
    public TextMeshProUGUI Phase;
    public TextMeshProUGUI Rounds;
    public TextMeshProUGUI Drawing;
    public bool Draw;

    public void Start()
    {
        Drawing.text = ""; 
    }
    public void NextPhase()
    {
        State += 1;
    }
    public void DrawingPhase()
    {
        if (Draw == false)
        {
            Drawing.text = "You Can't Draw Yet";
        }
        if (Draw == true)
        {
            State += 1;
            Debug.Log("Drawing The Card");
            Drawing.text = " ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        Rounds.text = "Round " + Round.ToString();
        if (State == 0)
        {
            Phase.text = "Draw A Card";
            GameManager.Instance.UpdateGameState(GameManager.GameStates.DrawPhase);
            Draw = true;
        }
        if (State == 1)
        {
            Phase.text = "Play Your Cards";
            GameManager.Instance.UpdateGameState(GameManager.GameStates.MainPhase);
            Draw = false;
        }
        if (State == 2)
        {
            Phase.text = "Attack Your Oppenent";
            GameManager.Instance.UpdateGameState(GameManager.GameStates.AttackPhase);
        }
        if (State == 3)
        {
            Phase.text = "Player Two Turn";
            GameManager.Instance.UpdateGameState(GameManager.GameStates.EndPhase);
        }

        if (State == 4)
        {
            State = 0;
            Round += 1;
        }
    }
}
