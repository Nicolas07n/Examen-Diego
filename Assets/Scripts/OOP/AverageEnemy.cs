using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AverageEnemy:Enemy
{
    private GameObject target;

    public AverageEnemy(Rigidbody2D rb, GameObject target) : base(15f, rb, null)
    {
        this.target = target;
    }

    public override void Move()
    {
        Vector2 dir = (target.transform.position - rb.transform.position).normalized;
        rb.velocity = dir * speed;
    }

    public override void Hit()
    {
        // No hace nada
    }

}
