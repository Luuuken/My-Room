using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactionDistance = 3f;
    [SerializeField] private Transform mirrorPosition;
    [SerializeField] private Transform tv;
    [SerializeField] private Transform tvPosition;
    [SerializeField] private Transform furniturePosition;
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
        Debug.Log("Interacción con: " + objeto.name);

        if (objeto.name == "Mirror")
        {
            objeto.transform.position = mirrorPosition.position;
            objeto.transform.rotation = mirrorPosition.rotation;
        }

        if (objeto.name == "Furniture1")
        {
            objeto.transform.position = furniturePosition.position;
            objeto.transform.rotation = furniturePosition.rotation;
        }

        if (objeto.name == "TV")
        {
            tv.SetPositionAndRotation(
                tvPosition.position,
                tvPosition.rotation
            );
        }

        if (objeto.name == "Bed")
        {
            objeto.transform.position = bedPosition.position;
            objeto.transform.rotation = bedPosition.rotation;
        }
    }
}