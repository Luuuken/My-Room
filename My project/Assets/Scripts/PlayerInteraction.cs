using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactionDistance = 3f;

    [SerializeField] private Transform mirrorPosition;
    [SerializeField] private Transform tvPosition;
    [SerializeField] private Transform Desk1Position;
    [SerializeField] private Transform Desk2Position;
    [SerializeField] private Transform ACPosition;
    [SerializeField] private Transform TablePosition;

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

            if (Input.GetKeyDown(KeyCode.E))
            {
                Interactuar(hit.collider.gameObject);
            }
        }
    }

    void Interactuar(GameObject objeto)
    {
        Debug.Log("Interacción con: " + objeto.name);

        // ESPEJO
        if (objeto.name == "Mirror")
        {
            objeto.transform.position = mirrorPosition.position;
            objeto.transform.rotation = mirrorPosition.rotation;
        }

        // MUEBLE
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

        // TELEVISOR
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
            objeto.transform.position = TablePosition.position;
            objeto.transform.rotation = TablePosition.rotation;
        }

    }
}