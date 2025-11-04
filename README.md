# Interfaces Inteligentes. Práctica 6. XR Interaction Toolkit.

## Ejercicio.

Para la realización de este ejercicio, ha sido necesario, además de toda la configuración previa, añadir el GameObject `XR Origin (XR Rig)`, que nos ha servido como controlador. 

Por otra parte, se han creado también un primer cubo que se ha colocado en la lejanía y al que se le ha añadido el componente `XR Simple Interactable`. Luego, se ha creado el siguiente [script](), en el que se han definido las funciones `OnSelectEnter(SelectEnterEventArgs informacionSelect)` y `OnSelectExit(SelectExitEventArgs informacionSelect)` para luego suscribirlas manualmente desde el inspector de propiedades a las funciones `SelectEntered` y `SelectExited`.