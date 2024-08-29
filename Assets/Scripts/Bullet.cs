using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D bulletRigidbody;

    private void OnEnable()
    {
        bulletRigidbody = GetComponent<Rigidbody2D>();

        bulletRigidbody.AddForce(new Vector2(800, 0));
        bulletRigidbody.gravityScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log(collision.gameObject.name);


            GameObject.Destroy(gameObject);
        }
        
    }
}
