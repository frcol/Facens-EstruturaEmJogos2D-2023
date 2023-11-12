using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RevisaoAC2
{
    public class Shooter : MonoBehaviour
    {
        public GameObject projectile;
        public float speed;
        public AudioClip clip;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GameManager.PlayFX(clip);

                GameObject goTemp = Instantiate(projectile, transform.position, transform.rotation);
                goTemp.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
                Destroy(goTemp, 4);
            }
        }
    }
}