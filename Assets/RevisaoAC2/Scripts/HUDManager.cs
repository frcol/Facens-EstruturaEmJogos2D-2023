using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RevisaoAC2
{
    public class HUDManager : MonoBehaviour
    {
        public TMP_Text txtScore;
        public TMP_Text txtLives;

        private void Start()
        {
            txtScore.text = "0";
            txtLives.text = "10";
        }

        public void SetScore(int value)
        {
            txtScore.text = value.ToString();
        }

        public void SetLives(int value)
        {
            txtLives.text = value.ToString();
        }
    }
}