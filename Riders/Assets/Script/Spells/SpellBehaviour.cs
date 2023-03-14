using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBehaviour : MonoBehaviour
{


    public SpellSO Spell;
    private void Update()
    {
        switch (Spell.caster)
        {
            case SpellSO.Caster.Projectile:
                /* GameObject spell = Instantiate(chuj, transform.position, Quaternion.identity);
                 Vector2 myPos = transform.position;
                 Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                 Vector2 direction = (mousePos - myPos).normalized;
                 spell.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;*/
                Debug.Log("chuj");
                break;
            case SpellSO.Caster.Self:
                break;
        }
    }
}
