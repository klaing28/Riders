using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public static Fighter instance;
    public int hitpoint=10;
    public int maxHitpoint = 10;
    public float maxMana = 100f;
    public float currentMana;
    public float manaRechargeRate = 2f;
    public float pushRecoverySpeed = 0.2f;

    protected float immuneTime = 1f;
    protected float lastImmune;

    protected Vector3 pushDirection;

    protected virtual void ReceiveDamage(Damage dmg)
    {
        if (Time.time - lastImmune > immuneTime)
        {
            lastImmune = Time.time;
            hitpoint -= dmg.damageAmount;
            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;

            GameManager.instance.ShowText(dmg.damageAmount.ToString(), 25, Color.red, transform.position, Vector3.zero, 0.3f);

            if (hitpoint <= 0)
            {
                hitpoint = 0;
                Death();
            }
        }
        
    }   
    
    protected virtual void Death()
    {
        Destroy(gameObject);
    }    
}
