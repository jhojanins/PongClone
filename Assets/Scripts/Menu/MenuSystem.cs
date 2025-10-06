using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    public void Jugar()
    {
        // Carga la escena llamada "SampleScene"
        SceneManager.LoadScene("SampleScene");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del Juego.....");
        Application.Quit();
    }
}
