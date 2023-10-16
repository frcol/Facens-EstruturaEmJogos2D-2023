using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public GameObject beeGO;
    public SpriteRenderer skeletonSpriteRenderer;
    
    private SpriteRenderer beeSR;

    public Enemy enemy;

    private void Start()
    {
        beeSR = beeGO.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (beeSR.color == Color.white)
            {
                //beeSR.color = Color.red;
                //skeletonSpriteRenderer.color = Color.green;

                enemy.ChangeColor();
            }
            else
            {
                //beeSR.color = Color.white;
                //skeletonSpriteRenderer.color = Color.white;
            }
        }  
    }
}
