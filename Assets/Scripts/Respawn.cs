using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Respawn : MonoBehaviour
{

    public GameObject posInicio;
    public GameObject objLanzar;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Trigger con: " + other.name);

        if (other.tag.Equals("Player"))
        {
            GameObject obj = Instantiate(objLanzar, posInicio.transform.position,
            posInicio.transform.rotation) as GameObject;

            obj.name = "Enemigo" + i;

            Destroy(obj, 4);
        }

        

    }


}
