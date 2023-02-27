using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriter : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 posDif;
    public Camera cam;

    public SpriteRenderer spriteRenderer;
    public Sprite right;
    public Sprite left;
    public Sprite up;
    public Sprite down;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        posDif = mousePos - new Vector2(transform.position.x, transform.position.y);

       // Debug.Log(posDif);

        if (posDif.x > 0)
        {
            if (posDif.x * posDif.x > posDif.y * posDif.y)
            {
                spriteRenderer.sprite = right;
            }
            else
            {
                if (posDif.y > 0)
                {
                    spriteRenderer.sprite = up;
                }
                if (posDif.y < 0)
                {
                    spriteRenderer.sprite = down;
                }

            }
        }
        if (posDif.x < 0)
        {
            if (posDif.x * posDif.x > posDif.y * posDif.y)
            {
                spriteRenderer.sprite = left;
            }
            else
            {
                if (posDif.y > 0)
                {
                    spriteRenderer.sprite = up;
                }
                if (posDif.y < 0)
                {
                    spriteRenderer.sprite = down;
                }
            }
        }
    }
    
}
