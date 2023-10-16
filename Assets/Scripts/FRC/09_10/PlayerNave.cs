using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNave : MonoBehaviour
{
    public Enemy2 enemy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemy.Damage();
        }        
    }
}
