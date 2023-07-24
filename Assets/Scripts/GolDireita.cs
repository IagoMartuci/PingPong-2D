using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolDireita : MonoBehaviour
{
    public AudioSource somGolPlayerOne;

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
            somGolPlayerOne.Play();
            FindObjectOfType<GameManager>().AumentarPontuacaoPlayerOne();
            // Comando para a Unity acessar a posi��o do gameObject que colidiu com o nosso trigger
            // E zerar a posi��o dele, ou seja, posicionar no centro da tela.
            collision.gameObject.transform.position = Vector2.zero;
        }
    }
}
