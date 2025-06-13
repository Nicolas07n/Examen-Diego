using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Enemy
{
    protected float speed;
    protected Rigidbody2D rb;
    protected Sprite sprite;

    public Enemy(float speed, Rigidbody2D rb, Sprite sprite)
    {
        this.speed = speed;
        this.rb = rb;
        this.sprite = sprite;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }
    public Enemy()
    {

    }
    public abstract void Move();
    public virtual void Hit() { }
}
