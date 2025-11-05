using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambioColorSeleccion : MonoBehaviour
{
    private Renderer rend;
    private Color colorOriginal;
    private Color nuevoColor;

    public void OnSelectEnter(SelectEnterEventArgs informacionSelect)
    {
        rend.material.color = nuevoColor;
    }

    public void OnSelectExit(SelectExitEventArgs informacionSelect)
    {
        rend.material.color = colorOriginal;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        colorOriginal = rend.material.color;
        nuevoColor = Color.crimson;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
