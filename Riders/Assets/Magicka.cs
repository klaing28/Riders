using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magicka : MonoBehaviour
{
    private float maxMana = 100f;
    private float currentMana;
    private Transform castpoint;
    private float manaRechargeRate = 2f;
    public float timeBetweenCasts = 1f;
    bool isCasting = false;
    private float currentCastTimer;

    // Update is called once per frame
    void Update()
    {

        isCasting = Input.GetKey(KeyCode.Mouse1);

        if (isCasting && currentCastTimer > timeBetweenCasts)
        {
            currentCastTimer = 0;
            print("BRRRRRRRRRRR");
           
        }

        if(isCasting)
        {
            currentCastTimer += Time.deltaTime;
            if(currentCastTimer>timeBetweenCasts)
            {
                isCasting = false;
            }
        }
    }

    void CastSpell()
    {
        print("AA");
    }
}
