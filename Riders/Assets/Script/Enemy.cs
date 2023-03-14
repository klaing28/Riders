using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Mover
{
    public int xpValue = 1;
    public float keptdistance=1;
    public float triggerLength = 1;
    public float chaseLength = 5;
    private bool chasing;
    private bool collidingWithPlayer;
    private Transform playerTransform;
    private Vector3 startingPosition;
    private float cooldownTimeLeft;
    public ContactFilter2D filter;
    private BoxCollider2D hitbox;
    public float cooldownTime;
    public float projectileSpeed;
    public GameObject projectile;
    private Collider2D[] hits = new Collider2D[10];
    //public Text souls;

    protected override void Start()
    {
        base.Start();
        playerTransform = GameManager.instance.player.transform;
        startingPosition = transform.position;
        hitbox = transform.GetChild(0).GetComponent<BoxCollider2D>();

    }


    private void FixedUpdate()
    {
        if (cooldownTimeLeft > 0)
        {
            cooldownTimeLeft -= Time.deltaTime;
        }

        if (Vector3.Distance(playerTransform.position,startingPosition)<chaseLength )
        {
            if (Vector3.Distance(playerTransform.position, startingPosition) < triggerLength)
                chasing = true;


            if(chasing)
            {
                if(!collidingWithPlayer && Vector3.Distance(playerTransform.position, transform.position) > keptdistance)    
                {
                    UpdateMotor((playerTransform.position - transform.position).normalized);
                }    
                else if(Vector3.Distance(playerTransform.position, transform.position) <= (keptdistance*0.7))
                {
                    UpdateMotor(-(playerTransform.position - transform.position).normalized*0.5f);
                }


                if (cooldownTimeLeft < 0.1)
                {
                    
                    
                        GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
                        Vector2 x = playerTransform.position;
                        Vector2 myPos = transform.position;
                        Vector2 direction = (x - myPos).normalized;
                        spell.GetComponent<Rigidbody2D>().velocity = direction * projectileSpeed;
                        cooldownTimeLeft = cooldownTime;
                    

                }
                
                

            }
            else
            {
                UpdateMotor(startingPosition - transform.position);
            }
        }
        else
        {
            UpdateMotor(startingPosition - transform.position);
            chasing = false;

        }

        collidingWithPlayer = false;
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            if(hits[i].tag == "Combat" && hits[i].name == "Player")
            {
                collidingWithPlayer = true;
            }

            hits[i] = null;
        }

    }

    protected override void Death()
    {
        Destroy(gameObject);
        GameManager.instance.ShowText("+" + xpValue + " xp", 25, Color.magenta, transform.position, Vector3.up * 30, 2.0f);
        GameManager.instance.pesos += xpValue;
        //souls.text = GameManager.instance.pesos.ToString();

    }
}
