using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1 : MonoBehaviour
{
    public SpriteRenderer srGo1;
    public SpriteRenderer srGo2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            srGo1.enabled = !srGo1.enabled;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            srGo2.enabled = !srGo2.enabled;
        }
    }
}
