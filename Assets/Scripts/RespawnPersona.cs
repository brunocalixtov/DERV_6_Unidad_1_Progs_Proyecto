using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RespawnPersona : MonoBehaviour
{

    public GameObject posInicio;
    public GameObject objLanzar;
    public TextMeshProUGUI txt_vida;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(objLanzar, posInicio.transform.position, posInicio.transform.rotation) as GameObject;

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

    }


}
