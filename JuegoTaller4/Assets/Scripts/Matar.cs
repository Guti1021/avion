using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{
    GameObject canvasGameOver;
    GameObject canvasJuego;
    private void Start()
    {
        canvasGameOver = GameObject.Find("GameOver");
        canvasJuego = GameObject.Find("Canvas");
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            canvasGameOver.gameObject.SetActive(true);
            canvasJuego.gameObject.SetActive(false);
        }
    }

}
