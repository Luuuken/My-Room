using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;

    void Start()
    {
        dialogueText.text = "";
        Invoke("MostrarPrimerDialogo", 3f);
    }

    void MostrarPrimerDialogo()
    {
        MostrarDialogo("¿Qué pasó con mi cuarto?");
    }

    public void MostrarDialogo(string texto)
    {
        dialogueText.text = texto;
    }

    public void OcultarDialogo()
    {
        dialogueText.text = "";
    }
}