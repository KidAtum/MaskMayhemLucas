using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ComplianceMeter : MonoBehaviour
{
    public float complianceMtr = 100;
    public float TotalCompliance = 100; 

    public GameObject ComplianceBarUI;
    public Slider slider; 


void Start ()
    {
        complianceMtr = TotalCompliance;
        slider.value = VacCalc();
    } 

void Update()
    { 
        //update health each frame checking for damage
        slider.value = VacCalc();
        if (complianceMtr <= 0)
        {
            Destroy(gameObject);
        }
    }


public void takeDmg(float amnt)
    {
        complianceMtr += -amnt;
        if (complianceMtr <= 0)
        {
            print("Enemy is complying");
        } else if (complianceMtr > 0)
        {
            print("Enemy is not complying.");
        }
    }

    float VacCalc()
    {
        return complianceMtr / TotalCompliance; 
    }


}
