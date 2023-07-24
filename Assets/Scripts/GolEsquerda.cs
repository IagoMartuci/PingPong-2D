using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolEsquerda : MonoBehaviour
{
    public AudioSource somGolPlayerTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bolinha"))
        {
            somGolPlayerTwo.Play();
            FindObjectOfType<GameManager>().AumentarPontuacaoPlayerTwo();
            // Comando para a Unity acessar a posição do gameObject que colidiu com o nosso trigger
            // E zerar a posição dele, ou seja, posicionar no centro da tela.
            collision.gameObject.transform.position = Vector2.zero;
        }
    }
}
