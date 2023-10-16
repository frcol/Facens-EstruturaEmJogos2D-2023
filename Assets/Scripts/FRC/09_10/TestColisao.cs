using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColisao : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<SpriteRenderer>().color = Color.red;
            collision.GetComponent<Enemy2>().Damage();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            collision.collider.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            collision.collider.GetComponent<SpriteRenderer>().color = Color.white;
        } 
    }

}
