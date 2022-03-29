using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDMG : MonoBehaviour
{
    public GameManager gm;
    
    public int PlayerDMG;
    public int EnemyDMG;

    public bool DMG;

    private void Update()
    {
        if (gm.Attacking == true)
        {
            DMG = true;
        }
        else
        {
            PlayerDMG = 0;
            EnemyDMG = 0;
        }
    }
}
