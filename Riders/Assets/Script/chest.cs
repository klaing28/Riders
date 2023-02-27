using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount;
    //public Text souls;
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.pesos += pesosAmount;
            //souls.text = GameManager.instance.pesos.ToString();
            GameManager.instance.ShowText("+" + pesosAmount + " souls",25,Color.yellow,transform.position,Vector3.up*30, 2.0f);
        }
    }
}
