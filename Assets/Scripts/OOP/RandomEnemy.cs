using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : Enemy
{
    private Vector2 dir;
    private float timeToSpin;
    private float currentTime;
    private bool confused;

    public RandomEnemy()
    {
        // Constructor vacío.
    }

    public RandomEnemy(Rigidbody2D rb, Vector2 dir, float timeToSpin) : base(10f, rb, null)
    {
        this.dir = dir.normalized;
        this.timeToSpin = timeToSpin;
        this.currentTime = 0f;
        this.confused = false;
    }

    public override void Move()
    {
        if (confused)
        {
            currentTime += Time.deltaTime;
            rb.transform.Rotate(0, 0, 360f * Time.deltaTime); 

            if (currentTime >= timeToSpin)
            {
                confused = false;
                currentTime = 0f;
                dir = -dir; 
            }
        }
        else
        {
            rb.velocity = dir * speed;
        }
    }

    public override void Hit()
    {
        confused = true;
        currentTime = 0f;
    }
}
