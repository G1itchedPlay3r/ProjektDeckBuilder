using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private GameStates State;

    public static GameManager Instance;

    public int PlayerOneHP;
    public int PlayerTwoHP;

    public TextMeshProUGUI P1HP;
    public TextMeshProUGUI P2HP;
    public TextMeshProUGUI Winner;

    public bool Playing = true;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        State = GameStates.MainPhase;
        Winner.text = " ";
    }

    private void Update()
    {
        P1HP.text = "P1: " + PlayerOneHP.ToString();
        P2HP.text = "P2: " + PlayerTwoHP.ToString();

        if (Input.GetMouseButtonDown(4) && Playing == true)
        {
            PlayerOneHP -= 1;
        }
        if (Input.GetMouseButtonDown(3) && Playing == true)
        {
            PlayerTwoHP -= 1;
        }

        if (PlayerOneHP == 0)
        {
            Winner.text = "Player 2 Won";
            Playing = false;
        }
        if (PlayerTwoHP == 0)
        {
            Winner.text = "Player 1 Won";
            Playing = false;
        }
    }

    public void UpdateGameState(GameStates newState)
    {
        State = newState;
        switch (State)
        {
            case GameStates.DrawPhase:
                Debug.Log("Draw Your Card");
                break;
            case GameStates.MainPhase:
                Debug.Log("Play Your Cards");
                break;
            case GameStates.AttackPhase:
                Debug.Log("Chose Your Attacks");
                break;
            case GameStates.EndPhase:
                Debug.Log("Player Two Turn");
                break;
        }
    }

    public enum GameStates
    {
        DrawPhase,
        MainPhase,
        AttackPhase,
        EndPhase
    }
}
