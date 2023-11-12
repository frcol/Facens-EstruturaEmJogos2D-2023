using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RevisaoAC2
{

    public enum TipoColetavel
    {
        LIVE,
        SCORE
    }

    public class MyCollectable : MonoBehaviour
    {
        public TipoColetavel tipo;
        public int value = 1;
        public GameObject fx;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Bullet"))
            {
                switch (tipo)
                {
                    case TipoColetavel.SCORE:
                        GameManager.SetScore(value);
                        break;
                    case TipoColetavel.LIVE:
                        GameManager.SetLive(value);
                        break;
                }

                Instantiate(fx, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}