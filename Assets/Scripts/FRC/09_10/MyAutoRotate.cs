using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAutoRotate : MonoBehaviour
{
    Rigidbody2D rb;
    public float torque;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.AddTorque(torque * -1);
    }
}
