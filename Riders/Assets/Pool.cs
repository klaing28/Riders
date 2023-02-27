using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pool : Collectable
{
    public int HP = 1;
    public Sprite emptyPool;
    //private float HPcd = 1.0f;
    //private float lastheal;


    protected override void OnCollide(Collider2D coll)
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyPool;
            GameManager.instance.player.Heal(HP);
        }
       
    }
}
