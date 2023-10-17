using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetControl : MonoBehaviour
{
    ParticleSystem particle;

    void Start()
    {
        particle =  GetComponentInChildren<ParticleSystem>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            particle.Play();
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            particle.Stop();
        }
    }
}
