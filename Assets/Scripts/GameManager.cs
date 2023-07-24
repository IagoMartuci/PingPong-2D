using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
// Para podermos usar comandos de interface de usuario
using UnityEngine.UI;
// Comandos de carregamento de cena
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoPlayerOne;
    public int pontuacaoPlayerTwo;
    public Text textoPlacar;
    public bool isPause;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Saiu do jogo!");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isPause = !isPause;

            if (isPause == true)
            {
                Pause();
            }
            else
            {
                UnPause();
            }
        }
    }

    void UnPause()
    {
        Time.timeScale = 1;
    }

    void Pause()
    {
        Time.timeScale = 0;
    }

    public void AumentarPontuacaoPlayerOne()
    {
        pontuacaoPlayerOne += 1;
        AtualizarTextoPontuacaoNoPlacar();
    }

    public void AumentarPontuacaoPlayerTwo()
    {
        pontuacaoPlayerTwo += 1;
        AtualizarTextoPontuacaoNoPlacar();
    }

    public void AtualizarTextoPontuacaoNoPlacar()
    {
        textoPlacar.text = pontuacaoPlayerOne + " x " + pontuacaoPlayerTwo;

        //if (pontuacaoPlayerOne == 10 || pontuacaoPlayerTwo == 10)
        //{
        //    SceneManager.LoadScene(0);
        //}
    }
}
