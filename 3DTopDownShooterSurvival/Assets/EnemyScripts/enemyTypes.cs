using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTypes<T> where T:enemyTypes
{
    public GameObject GameObject;
    public T scriptComponent;

    public enemyTypes(string name)
    {
        GameObject = new GameObject(name);
        scriptComponent = GameObject.AddComponent<T>();
    }
}

public abstract class enemyTypes : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer Sprite;
    public CircleCollider2D Collider;

    public int Speed;
    public int Dir;

    protected abstract void movementPattern();

    private void Awake()
    {
        //common components

        rb =gameObject.GetComponent<Rigidbody2D>();
        Sprite = gameObject.GetComponent<SpriteRenderer>();
        Collider =gameObject.GetComponent<CircleCollider2D>();

        Sprite.sprite = Resources.Load<Sprite>("Ball");
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;

        gameObject.tag = "Enemy";
        gameObject.layer = LayerMask.NameToLayer("Ball");

    }
    public void initialize(int speed,int dir,Vector3 pos)
    {
        Speed = speed;
        Dir = dir;
        transform.position = pos;
    }
    public void initialize(int speed, Vector3 pos)
    {
        Speed = speed;
        transform.position = pos;
    }

}


