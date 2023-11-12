using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RevisaoAC2
{
    public class MyModifyHealthAttribute : MonoBehaviour
    {
        public GameObject fxLive;
        public string tag;

        private float largura;

        private void Start()
        {
            largura = GetComponent<Collider2D>().bounds.size.x/2;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag(tag))
            {
                GameManager.SetLive(-1);
                Instantiate(fxLive, collision.contacts[0].point + (Vector2)transform.right * largura, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}