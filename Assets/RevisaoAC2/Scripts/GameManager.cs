using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RevisaoAC2
{
    public class GameManager : MonoBehaviour
    {
        private static AudioSource audio;
        private static HUDManager hud;

        public static int score=0;
        public static int lives=10;

        void Start()
        {
            hud = FindAnyObjectByType<HUDManager>();
            audio = GetComponent<AudioSource>();

            lives = 10;
            score = 0;
        }

        public static void SetScore(int value)
        {
            score += value;
            print("Score: "+score);
            hud.SetScore(score);
        }

        public static void SetLive(int value)
        {
            lives += value;
            print("Lives: "+lives);
            hud.SetLives(lives);
        }

        public static void PlayFX(AudioClip clip)
        {
            if (audio != null)
            {
                audio.PlayOneShot(clip);
            }
        }
    }
}

