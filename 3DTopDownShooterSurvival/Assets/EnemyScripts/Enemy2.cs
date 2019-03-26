using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : enemyTypes
{
    private void Start()
    {
        Collider.radius = 0.21f;
        transform.localScale = new Vector3(5, 5, 1);
        rb.gravityScale = 2;
        rb.mass = 2;

        GameObject hero = GameObject.Find("hero");
        Dir = (hero.transform.position.x - transform.position.x < 0) ? -1 : 1;
    }

    private void FixedUpdate()
    {
        movementPattern();
    }

    protected override void movementPattern()
    {
        rb.velocity = new Vector2(Speed * Dir, rb.velocity.y);
    }

}
