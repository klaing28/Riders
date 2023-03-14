using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemy : Collidable
{
    public int damagePoint = 1;
    public float pushForce = 2.0f;
    public float aoe;




    protected override void OnCollide(Collider2D coll)
    {
        if (coll.tag == "Combat")
        {
            if (coll.name == "Player")
            {
                Damage dmg = new Damage
                {
                    damageAmount = damagePoint,
                    origin = transform.position,
                    pushForce = pushForce
                };

                coll.SendMessage("ReceiveDamage", dmg);
            }

        }
        if (coll.name == "Player" || coll.tag == "Wall")
        {
                Destroy(gameObject);
            
        }
    }

}
