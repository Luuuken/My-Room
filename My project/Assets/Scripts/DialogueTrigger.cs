using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea]
    [SerializeField] private string dialogue;

    [TextArea]
    [SerializeField] private string dialogueAfter;

    private bool acomodado = false;

    public string GetDialogue()
    {
        if (acomodado)
        {
            return "";
        }

        return dialogue;
    }

    public string GetDialogueAfter()
    {
        return dialogueAfter;
    }

    // Devuelve true si se marca por primera vez (para evitar doble contado)
    public bool MarcarComoAcomodado()
    {
        if (acomodado)
        {
            return false;
        }

        acomodado = true;
        return true;
    }
}