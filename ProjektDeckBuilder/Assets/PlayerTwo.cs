using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayerTwoHP = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
