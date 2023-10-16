using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_EA : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();    
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float xVel = Mathf.Abs(rb.velocity.x);
        anim.SetFloat("speed", xVel);
    }
}
