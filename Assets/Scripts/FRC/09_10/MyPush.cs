using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPush : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float force;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        //float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        direction = new Vector2(0, ver);

        rb.AddForce(direction * force);
    }
}
