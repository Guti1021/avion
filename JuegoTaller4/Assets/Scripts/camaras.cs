using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaras : MonoBehaviour
{
    public Camera CamaraInicio;
    public Camera CamaraJuego;

    public void ShowOverheadView()
    {
        CamaraInicio.enabled = false;
        CamaraJuego.enabled = true;
    }

    public void ShowFirstPersonView()
    {
        CamaraInicio.enabled = true;
        CamaraJuego.enabled = false;
    }
}
