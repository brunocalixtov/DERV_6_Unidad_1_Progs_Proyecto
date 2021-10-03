using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMouse : MonoBehaviour
{

    public float speedX = 20;

    public float speedY = 5;

    float ejeRotaObj;

    float ejeRotaCam;

    Rigidbody rb;

    public GameObject camera;

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
        ejeRotaObj = Input.GetAxis("Mouse X");
        ejeRotaCam += Input.GetAxis("Mouse Y") * speedX;

        transform.Rotate(0, ejeRotaObj * speedY, 0);

        ejeRotaCam = Mathf.Clamp(ejeRotaCam, -25, 25);
        camera.transform.localEulerAngles = new Vector3(-ejeRotaCam, 0f, 0f);
    }

}
