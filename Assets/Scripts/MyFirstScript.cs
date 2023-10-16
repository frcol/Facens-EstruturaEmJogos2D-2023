using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    int vidas = 2;
    public string cor = "Red";

    void Start()
    {
        for (int i=1; i <= 1000; i++ )
        {
            print(i);
        }
    }

    void Update()
    {
        
    }

    public void MeuMetodo()
    {
        print("Entrou no meu metodo");
    } 
}
