using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool iniciado = false;
    public GameObject playerGame;
    public GameObject textoCanvas;
    public bool pausado = false;

    private void iniciaJogo()
    {
        iniciado = true;
        playerGame.GetComponent<Player>().enabled = true;
        playerGame.GetComponent<BoxCollider>().enabled = true;
        textoCanvas.SetActive(false);

    }
    private void pausaJogo()
    {
        Time.timeScale = 0;
    }

    private void despausaJogo()
    {
        Time.timeScale = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Derrubar") && iniciado == false)
        {
            iniciaJogo();
        }

        if (Input.GetButtonDown("Pausar") && pausado == false)
        {
            pausaJogo();
        }
    }
}
