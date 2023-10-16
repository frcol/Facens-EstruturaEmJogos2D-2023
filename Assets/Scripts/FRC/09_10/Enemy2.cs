using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int vidas = 3;

    public void Damage()
    {
        vidas--;

        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }
}
