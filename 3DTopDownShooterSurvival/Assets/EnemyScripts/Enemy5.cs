using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5 : enemyTypes
{
    private void Start()
    {
        Collider.radius = 0.19f;
    }

    private void FixedUpdate()
    {
        movementPattern();
    }

    protected override void movementPattern()
    {
        if (rb.velocity.y < 0)
            rb.AddTorque((float)Speed / 2 * Dir);
        else if (rb.velocity.y > 0)
            rb.AddForce(new Vector2(0, 100));
    }
}
