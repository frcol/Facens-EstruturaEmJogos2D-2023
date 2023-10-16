using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // vida

    public void ChangeColor()
    {
        GetComponent<SpriteRenderer>().color = Color.red;

        Destroy(gameObject);
    }

    // metodo TomaDano()
        // tira vida -1
        // Se vida <= 0 
            // Destrua o 
}
