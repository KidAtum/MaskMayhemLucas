using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public Camera cam;
    public GameObject Hand;
    public weapon myWeapon;

    Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        //create the weapon - default to hand
        //can expand this to include ruler? maybe a chair? idek im tired
        myWeapon = Hand.GetComponentInChildren<weapon>();
        animator = GetComponentInChildren<Animator>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            DoAttack();
            animator.SetTrigger("attackHappens");
            //animator.ResetTrigger("attackHappens");
        }
    }

    private void DoAttack()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, myWeapon.attackRange))
        {
            if (hit.collider.tag == "Enemy")
            {
                ComplianceMeter measureMtr = hit.collider.GetComponent<ComplianceMeter>();
                measureMtr.takeDmg(myWeapon.attackDmg);
            }
        }
    }

}
