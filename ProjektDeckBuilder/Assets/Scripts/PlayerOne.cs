using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayerHP = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
