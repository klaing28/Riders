using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    //private Spell spellToCast;
    private Vector2 mousePos;
    private Vector2 posDif;
    bool isCasting = false;
    
    public float cooldownTime;
    public float cooldownTimeLeft;

    // Update is called once per frame
    void Update()
    {

        isCasting = Input.GetKey(KeyCode.Mouse1);
        if(cooldownTimeLeft<0.1)
        {
            if(isCasting)
            {
                CastSpell();
                cooldownTimeLeft = cooldownTime;
            }
            
        }
        if (cooldownTimeLeft > 0)
        {
            cooldownTimeLeft -= Time.deltaTime;
        }


    }

    void CastSpell()
    {
        //Instantiate(spellToCast);
    }

}
