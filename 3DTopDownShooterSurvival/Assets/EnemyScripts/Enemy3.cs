using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : enemyTypes
{
    private void Start()
    {
        Destroy(Collider);
        Destroy(rb);

        Sprite.sortingOrder = 1;
        Sprite.material.color = new Color(1, 1, 1, 0.5f);
        transform.localScale = new Vector3(1.8f, 1.8f, 1);
    }

    private void Update()
    {
        movementPattern();
    }

    protected override void movementPattern()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            GameObject.Find("hero").transform.position,
            Speed*Time.deltaTime
            );
    }

}
