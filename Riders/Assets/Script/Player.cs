using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : Mover
{
    
    public Text souls;
    public Text hp;



    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
       
        UpdateMotor(new Vector3(x, y, 0));
        souls.text = "Souls:  " + GameManager.instance.pesos.ToString();
        hp.text = "Hp:  " + hitpoint.ToString();
    }

    public void Heal(int healingAmount)
    {
        if (hitpoint == maxHitpoint)
        {
            return;
        }

        hitpoint += healingAmount;
        if(hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
        }
            GameManager.instance.ShowText("+" + healingAmount.ToString() + "hp", 25, Color.green, transform.position, Vector3.up * 30, 1.0f);
        
    }
}
   