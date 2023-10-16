using UnityEngine;

public class Player : MonoBehaviour
{
    public int vida = 3;
    public int score = 0;

    private SpriteRenderer sr;
    private Transform meuTransform;
    private Animator animator;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        meuTransform = GetComponent<Transform>();
        animator = GetComponent<Animator>();

        sr.color = Color.red;

        meuTransform.Translate(5, 0, 0);

        // Debug.Log
        // Debug.LogWarning("O nome é "+nome+" e a vida é "+vida);
        // Debug.LogError("Aconteceu um erro aqui"); 
        /*
         * sdasdas
         * asdasdasd
         */
        vida = 5;
        TomaDano(-3);

        score = 10;

        AdicionaPontos(10);
    }

    private void Update()
    {
        if (score >= 10)
        {
            print("YOU WIN!!!");
        }
        else
        {
            print("Jogo em andamento...");
        }
    }

    private void TomaDano(int dano)
    {
        vida = vida + dano;
    }

    private void AdicionaPontos(int valor)
    {
        score = score + valor;
    }
}
