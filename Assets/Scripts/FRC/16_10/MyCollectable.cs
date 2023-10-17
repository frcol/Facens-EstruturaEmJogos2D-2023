using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                GameManager.addScore(value);
                break;
            case TipoColetavel.LIVE:
                GameManager.addLive(value);
                break;
        }
        
        Destroy(gameObject);
    }
}
