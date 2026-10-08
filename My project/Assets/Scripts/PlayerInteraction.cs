using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactionDistance = 3f;
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private Transform mirrorPosition;
    [SerializeField] private Transform tvPosition;
    [SerializeField] private Transform Desk1Position;
    [SerializeField] private Transform Desk2Position;
    [SerializeField] private Transform ACPosition;
    [SerializeField] private Transform TabletvPosition;
    [SerializeField] private Transform BedPosition;
    [SerializeField] private Transform ClosetPosition;
    [SerializeField] private Transform TablePosition;
    [SerializeField] private Transform Table2Position;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(
            playerCamera.transform.position,
            playerCamera.transform.forward,
            out hit,
            interactionDistance))
        {
            Debug.Log("Estoy mirando: " + hit.collider.gameObject.name);

            DialogueTrigger dialogue = hit.collider.GetComponent<DialogueTrigger>();

            if (dialogue != null)
            {
                string texto = dialogue.GetDialogue();

                if (!string.IsNullOrEmpty(texto))
                {
                    dialogueManager.MostrarDialogo(texto);
                }
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Interactuar(hit.collider.gameObject);

                if (dialogue != null)
                {
                    dialogue.MarcarComoAcomodado();

                    dialogueManager.MostrarDialogoTemporal(
                        dialogue.GetDialogueAfter(),
                        3f
                    );
                }
            }
        }
    }

    void Interactuar(GameObject objeto)
    {
        Debug.Log("Interacción con: " + objeto.name);

        if (objeto.name == "Mirror")
        {
            objeto.transform.position = mirrorPosition.position;
            objeto.transform.rotation = mirrorPosition.rotation;
        }

        if (objeto.name == "Desk1")
        {
            objeto.transform.position = Desk1Position.position;
            objeto.transform.rotation = Desk1Position.rotation;
        }

        if (objeto.name == "Desk2")
        {
            objeto.transform.position = Desk2Position.position;
            objeto.transform.rotation = Desk2Position.rotation;
        }

        if (objeto.name == "Tv")
        {
            objeto.transform.position = tvPosition.position;
            objeto.transform.rotation = tvPosition.rotation;
        }

        if (objeto.name == "AC")
        {
            objeto.transform.position = ACPosition.position;
            objeto.transform.rotation = ACPosition.rotation;
        }

        if (objeto.name == "TV Table")
        {
            objeto.transform.position = TabletvPosition.position;
            objeto.transform.rotation = TabletvPosition.rotation;
        }

        if (objeto.name == "Bed")
        {
            objeto.transform.position = BedPosition.position;
            objeto.transform.rotation = BedPosition.rotation;
        }

        if (objeto.name == "Closet")
        {
           objeto.transform.position = ClosetPosition.position;
           objeto.transform.rotation = ClosetPosition.rotation;
        }

        if (objeto.name == "Table")
        {
           objeto.transform.position = TablePosition.position;
           objeto.transform.rotation = TablePosition.rotation;
        }

        if (objeto.name == "Table2")
        {
           objeto.transform.position = Table2Position.position;
           objeto.transform.rotation = Table2Position.rotation;
        }

    }
}