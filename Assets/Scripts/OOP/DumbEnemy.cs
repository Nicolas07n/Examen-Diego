using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbEnemy:Enemy 
{
    private Vector2 dir;

    public DumbEnemy()
    {
        // Constructor vacío.
    }

    public DumbEnemy(Rigidbody2D rb) : base(30f, rb, null)
    {
        
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        dir = new Vector2(x, y).normalized;
    }

    public override void Move()
    {
        rb.velocity = dir * speed;
    }

    public override void Hit()
    {
        
        Debug.Log("DumbEnemy ha muerto.");
        GameObject.Destroy(rb.gameObject);
    }
}
