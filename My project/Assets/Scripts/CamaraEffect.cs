using UnityEngine;

public class CameraEffect : MonoBehaviour
{
    public float intensidad = 0.03f;
    public float velocidad = 5f;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.localPosition;
    }

    void Update()
    {
        float movimientoX = Mathf.Sin(Time.time * velocidad) * intensidad;
        float movimientoY = Mathf.Cos(Time.time * velocidad * 2) * intensidad;

        transform.localPosition = posicionInicial + new Vector3(movimientoX, movimientoY, 0);
    }
}