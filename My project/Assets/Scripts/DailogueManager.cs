using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;

    void Start()
    {
        dialogueText.text = "";
        Invoke("MostrarPrimerDialogo", 2f);
    }

    void MostrarPrimerDialogo()
    {
        MostrarDialogo("¿Qué pasó con mi cuarto? " + "tengo que ordenarlo");
        Invoke("OcultarDialogo", 3f);
    }

    public void MostrarDialogo(string texto)
    {
        CancelInvoke("OcultarDialogo");
        dialogueText.text = texto;
    }

    public void MostrarDialogoTemporal(string texto, float tiempo)
    {
        CancelInvoke("OcultarDialogo");

        dialogueText.text = texto;

        Invoke("OcultarDialogo", tiempo);
    }

    public void OcultarDialogo()
    {
        dialogueText.text = "";
    }
}