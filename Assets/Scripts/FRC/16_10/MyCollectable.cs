using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Aula_23_10;
public enum TipoColetavel
{
    LIVE,
    SCORE
}

public class MyCollectable : MonoBehaviour
{
    public TipoColetavel tipo;
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (tipo) {
            case TipoColetavel.SCORE:
                Aula_23_10.GameManager.AddScore(value);
                break;
            case TipoColetavel.LIVE:
                // Aula_23_10.GameManager.AddLive(value);
                break;
        }
        
        Destroy(gameObject);
    }
}
