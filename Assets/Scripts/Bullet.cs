using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 direction;
    public float speed = 10f;
    private int bounceCount = 0;
    private int maxBounces = 2;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = direction.normalized * speed;
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Ignorar colisión si el objeto está en la capa "Player"
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
            return;

        bounceCount++;

        if (bounceCount > maxBounces)
        {
            Destroy(gameObject);
        }
        else
        {
            // Invertir la dirección y seguir moviéndose
            direction = -direction;
            _rb.velocity = direction * speed;
        }
    }
}

