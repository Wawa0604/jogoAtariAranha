using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager"); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("vasinho"))
        {
            gameManager.GetComponent<GameManager>().score += 1;
            gameManager.GetComponent<GameManager>().atualizaScore();
            // Debug.Log(gameManager.GetComponent<GameManager>().score);
            gameObject.GetComponent<SphereCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;

            // Destroy(gameObject);

        }
    }
}
