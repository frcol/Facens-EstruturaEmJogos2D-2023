using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAutoMove : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 direction;
    public float force;

    public bool isRelative = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isRelative)
        {
            rb.AddRelativeForce(direction.normalized * force);
        }
        else
        {
            rb.AddForce(direction.normalized * force);
        }  
    }
}
