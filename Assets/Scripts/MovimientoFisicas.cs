using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisicas : MonoBehaviour
{
    public float desplazamiento = 10;
    //long i;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //i = 0;
        rb = GetComponent<Rigidbody>();
    }
    //frame
    void Update() 
    { 
    
    }
    //por tiempo
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Prueba");
        //Debug.Log("Prueba " + i);
        //i++;
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("Arriba");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
            //new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            rb.MovePosition(rb.position + transform.right * -1f * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Atras");
            rb.MovePosition(rb.position + transform.forward * -1f * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime);
        }
    }
}
