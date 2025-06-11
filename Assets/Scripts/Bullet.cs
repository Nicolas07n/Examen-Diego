using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 dir;
    public float speed;
    private Rigidbody2D rb;

    
    public float destroyTime = 3f;
    

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    public void SetDirection(Vector2 dir)
    {
        dir = dir.normalized;
    }

    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(gameObject);
    }
}
