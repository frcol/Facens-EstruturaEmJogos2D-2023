using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int live = 0;

    private void Start()
    {
        score = 0;
        live = 0;
    }
    public static void addScore(int value)
    {
        score = score + value;
        print("Score: "+score);
    }

    public static void addLive(int value)
    {
        live = live + value;
        print("Live: "+live);
    }
}
