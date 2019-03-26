using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy6 : enemyTypes
{
    float timer;
    public bool tweekout;

    private void Start()
    {
        Collider.radius = 0.16f;
        Sprite.material.color = new Color(1, 0.8f, 0, 1);
    }

    private void Update()
    {
        timer += Time.deltaTime * 60;

        if(timer>30)
        {
            tweekout = true;
            timer = 0;
        }
    }

    private void FixedUpdate()
    {
        movementPattern();
    }

    protected override void movementPattern()
    {
        if(tweekout)
        {
            float randomX = Random.Range(-29f, 29f);
            float randomY = Random.Range(-120f, 120f);

            rb.AddForce(new Vector2(randomX * Speed, randomY * Speed));
            tweekout = false;
        }
    }
}
