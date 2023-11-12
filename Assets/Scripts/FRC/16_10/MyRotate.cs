using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRotate : MonoBehaviour
{
    public float torque = 5;

    Rigidbody2D rb;
    float hor;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");

        rb.AddTorque(hor * torque * -1);
            
    }
}
