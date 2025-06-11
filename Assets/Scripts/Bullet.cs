using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 direction;
    public float speed = 10f;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = direction * speed;
    }

    // Llamado desde fuera para establecer la dirección
    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }
}
