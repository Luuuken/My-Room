using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class MenuManager : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Level");
    }

    public void Salir()
    {
        Application.Quit();
    }
}