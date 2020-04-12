using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mostrarCanvas : MonoBehaviour
{

    GameObject canvasJuego;
    GameObject canvasGameOver;
    moverAvion mover;
   
    void Start()
    {
        canvasJuego = GameObject.Find("Canvas");
        canvasJuego.gameObject.SetActive(false);
        mover = FindObjectOfType<moverAvion>();
        mover.enabled = false;
        canvasGameOver = GameObject.Find("GameOver");
        canvasGameOver.gameObject.SetActive(false);
    }

    public void OnMouseDown()
    {
        Debug.Log("Comenzó el juego");
        canvasJuego.gameObject.SetActive(true);
        mover.enabled = true;
        canvasGameOver.gameObject.SetActive(false);
    }

}
