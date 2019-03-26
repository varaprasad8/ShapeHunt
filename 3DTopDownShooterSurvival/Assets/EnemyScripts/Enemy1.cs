using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : enemyTypes
{
    private void Start()
    {
        Collider.radius = 0.19f;
        transform.localScale = new Vector3(1.2f, 1.2f, 1f);
    }

    private void FixedUpdate()
    {
        movementPattern();
    }
    protected override void movementPattern()
    {
        rb.velocity = new Vector2(1 * Dir, rb.velocity.y);

        if (rb.velocity.y == 0)
        {
            rb.AddForce(new Vector2(0, 300));
        }
    }
}
