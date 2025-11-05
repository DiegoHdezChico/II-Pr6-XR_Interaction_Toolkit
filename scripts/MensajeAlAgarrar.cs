using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MensajeAlAgarrar : MonoBehaviour
{
    public void LanzarMensaje(SelectEnterEventArgs args)
    {
        Debug.Log("Se ha agarrado el cubo");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
