using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class side : spriter
{
    Animator Animation;
    // Start is called before the first frame update
    void Start()
    {
        Animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(spriteRenderer.sprite == right)
        {
            Animation.SetInteger("Side", 1);
        }
        else if (spriteRenderer.sprite == up)
        {
            Animation.SetInteger("Side", 2);
        }
        else if (spriteRenderer.sprite == left)
        {
            Animation.SetInteger("Side", 3);
        }
        else if (spriteRenderer.sprite == down)
        {
            Animation.SetInteger("Side", 4);
        }

    }
}
