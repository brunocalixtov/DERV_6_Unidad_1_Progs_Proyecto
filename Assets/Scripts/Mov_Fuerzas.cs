using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Fuerzas : MonoBehaviour
{

    public float sF = 20;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * sF, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -1f * sF, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -1f * sF, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * sF, ForceMode.Acceleration);
        }

    }
}
