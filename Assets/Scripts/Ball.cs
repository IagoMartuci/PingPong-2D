using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool jogoIniciado;
    public float velocidadeBall;
    public Rigidbody2D oRigidbody2D;
    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start()
    {
        jogoIniciado = false;
        // Adicionando movimentação na bolinha com base na velocidade através dos eixos x e y
        //oRigidbody2D.velocity = new Vector2(velocidadeBall, velocidadeBall) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (jogoIniciado == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MovimentarBola();
                jogoIniciado = true;
            }
        }
    }

    public void MovimentarBola()
    {
        // Adicionando movimentação na bolinha com base na velocidade através dos eixos x e y
        oRigidbody2D.velocity = new Vector2(velocidadeBall, velocidadeBall) * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        somDaBola.Play();
    }
}
