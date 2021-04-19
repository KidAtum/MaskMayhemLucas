using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ComplianceMeter : MonoBehaviour
{
    public float complianceMtr = 30;

    public void takeDmg(float amnt)
    {
        complianceMtr = -amnt;
        if (complianceMtr <= 0)
        {
            print("Enemy is complying");
        } else if (complianceMtr > 0)
        {
            print("Enemy is not complying.");
        }
    }
}
