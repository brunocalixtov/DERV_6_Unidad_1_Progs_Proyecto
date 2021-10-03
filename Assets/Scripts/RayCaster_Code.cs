using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster_Code : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;
        RaycastHit hit; //almacena info de a colision
        float distancia = 150f; //distancia maxima del rayo, si no se establece es infinito
        //int layerMask; //capa con la que se desea validar la colision
                       //por defecto revisa todas las capas
        //QueryTriggerInteraction querryTrigger = QueryTriggerInteraction.Collide;
        //determina si la colision considerará a los objetos que 

        float duracionRayo = 1;

        if (Physics.Raycast(origen, direccion, out hit, distancia))
        {
            //hit es para extraer informacion del objeto con el que colisiona
            Debug.DrawRay(origen, direccion * hit.distance, Color.yellow, duracionRayo);
        }
        else
        {
            Debug.DrawRay(origen, direccion * distancia, Color.red, duracionRayo);
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        //origen, direccion
        Gizmos.DrawRay(transform.position, transform.forward * 20f);
    }
}
