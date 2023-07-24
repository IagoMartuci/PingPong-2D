using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float velocidadePlayer;
    public float limiteMinimoY;
    public float limiteMaximoY;
    public bool playerOne;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOne == true)
        {
            MovimentarPlayerOne();
        }
        else
        {
            MovimentarPlayerTwo();
        }
    }

    private void MovimentarPlayerOne()
    {
        LimitarMovimentoDoPlayerNoEixoY();

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadePlayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadePlayer * Time.deltaTime);
        }
    }

    private void MovimentarPlayerTwo()
    {
        LimitarMovimentoDoPlayerNoEixoY();

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadePlayer * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadePlayer * Time.deltaTime);
        }
    }

    private void LimitarMovimentoDoPlayerNoEixoY()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteMinimoY, limiteMaximoY));
    }
}
