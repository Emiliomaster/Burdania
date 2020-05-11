using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestMenu : MonoBehaviour
{
    public string NuevoJuego;

   
    public void NuevaPartida()
    {
        SceneManager.LoadScene(NuevoJuego);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
