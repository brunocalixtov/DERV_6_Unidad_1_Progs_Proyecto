using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza_VelocityChange : MonoBehaviour
{
    Rigidbody rb;

    public float speedF = 50;

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
        //rb.AddForce(new Vector3(0f, 0f, 0f), ForceMode.VelocityChange);
        rb.AddForce(Vector3.right * speedF, ForceMode.VelocityChange); //Global
        //rb.AddForce(transform.right * speedF, ForceMode.VelocityChange); //Local
    }
}
