using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ComplianceMeter : MonoBehaviour
{
    //vacine health 
    public float complianceMtr = 100;
    public float TotalCompliance = 100;

    //reference variables 
    public GameObject ComplianceBarUI;
    public Slider slider;



    void Start()
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
            //wait clock 
            //waitTimer(10);

            Destroy(gameObject, 2);
        }
    }

    //melee register against health 
    public void takeDmg(float amnt)
    {
        complianceMtr += -amnt;
        if (complianceMtr <= 0)
        {
            //debug enemy hit and has no health 
            print("Enemy is complying");
        } else if (complianceMtr > 0)
        {
            //enemy hit and has health
            print("Enemy is not complying.");
        }
    }

    float VacCalc()
    {
        //calculates the vaccine bar 
        return complianceMtr / TotalCompliance;
    }
  
}//end of file 
