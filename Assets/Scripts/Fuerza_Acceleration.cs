using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza_Acceleration: MonoBehaviour
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
        //rb.AddForce(new Vector3(0f, 0f, 0f), ForceMode.Acceleration);
        //rb.AddForce(Vector3.right * speedF, ForceMode.Acceleration); //Global
        rb.AddForce(transform.right * speedF, ForceMode.Acceleration); //Local
    }
}
