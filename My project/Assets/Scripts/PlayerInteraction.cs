using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactionDistance = 3f;
    [SerializeField] private Transform mirrorPosition;
    [SerializeField] private Transform bedPosition;
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
        Debug.Log("Interactuando con: " + objeto.name);

        if (objeto.name == "Mirror")
        {
            objeto.transform.position = mirrorPosition.position;
            objeto.transform.rotation = mirrorPosition.rotation;
        }

    }
}