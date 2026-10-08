using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public int objetosNecesarios = 10;

    private int objetosOrdenados = 0;

    public GameObject panelFinal;

    private HashSet<string> objetosYaOrdenados = new HashSet<string>();

    public void ObjetoOrdenado(string nombreObjeto)
    {
        if (objetosYaOrdenados.Contains(nombreObjeto))
            return;

        objetosYaOrdenados.Add(nombreObjeto);
        objetosOrdenados++;

        Debug.Log("Objetos ordenados: " + objetosOrdenados + "/" + objetosNecesarios);

        if (objetosOrdenados >= objetosNecesarios)
        {
            TerminarNivel();
        }
    }

    void TerminarNivel()
    {
        Debug.Log("¡¡¡TODOS LOS OBJETOS ESTAN ORDENADOS!!!");

        if (panelFinal != null)
        {
            panelFinal.SetActive(true);
            Debug.Log("PANEL FINAL ACTIVADO");
        }
        else
        {
            Debug.LogError("EL PANEL FINAL NO ESTA ASIGNADO");
        }
    }
}