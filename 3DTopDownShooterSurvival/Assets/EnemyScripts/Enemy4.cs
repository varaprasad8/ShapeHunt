using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : enemyTypes
{
    public float timer;
    public int HorizontalMotion;
    int MaxWobbleWidth;

    private void Start()
    {
        Collider.radius = 0.20f;
        Sprite.material.color = new Color(0.8f, 1, 1);
        transform.localScale = new Vector3(1.4f, 1.4f, 1);

        MaxWobbleWidth = 2000 / Speed;

        if (Camera.main.WorldToViewportPoint(transform.position).x > 0.5f)
            Dir = -1;
        else
            Dir = 1;

    }
    private void Update()
    {
        if (timer < MaxWobbleWidth / 2)
            HorizontalMotion = 1 * Dir;
        else if (timer < MaxWobbleWidth)
            HorizontalMotion = -1 * Dir;
        else if (timer > MaxWobbleWidth)
            timer = 0;
        timer += Time.deltaTime * 60;
    }

    private void FixedUpdate()
    {
        movementPattern();
    }

    protected override void movementPattern()
    {
        rb.AddForce(new Vector2(HorizontalMotion * Speed, rb.velocity.y), ForceMode2D.Force);

        if(rb.velocity.x<Speed/2*-1)
            rb.velocity = new Vector2(Speed / 2 * -1, rb.velocity.y);
        if (rb.velocity.x > Speed / 2)
            rb.velocity = new Vector2(Speed / 2, rb.velocity.y);
    }
}
