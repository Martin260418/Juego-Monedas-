﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    public void CambiaEscena (string nombre)
    {
       //print ("cambio de escena" + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir ()
        {
           print("Saliendo del juego");  
        }

}
