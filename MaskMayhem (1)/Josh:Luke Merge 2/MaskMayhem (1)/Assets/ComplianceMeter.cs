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
            print("Mr. Diaz is now obeying.");
        }
        print("Mr. Diaz took damage.");
    }
}
