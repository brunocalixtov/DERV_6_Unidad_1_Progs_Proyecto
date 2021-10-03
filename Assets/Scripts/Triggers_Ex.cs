using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Triggers_Ex : MonoBehaviour
{

    public TextMeshProUGUI HP;
    public TextMeshProUGUI SCORE;
    int hp;
    int score;


    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        score = 0;

        StartCoroutine("corrutinaVida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        string nombre = collision.gameObject.name;
        string tag = collision.gameObject.tag;

        Debug.Log("Colision con: " + nombre);

        if(tag.Equals("Enemigo"))
        {
            GameObject gameObj;
            gameObj = GameObject.Find(nombre);

            Destroy(gameObj);

            score++;
            SCORE.text = score.ToString();
            hp --;
            HP.text = hp.ToString();
        }

        
        
        


    }


    //corrutina
    IEnumerator corrutinaVida() {
        while (true)
        {

            hp-=1;
            HP.text = hp.ToString();
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        string tag = other.gameObject.tag;

        Debug.Log("Colision con: " + tag);

        if (tag.Equals("PowerUp"))
        {
            hp++;
            HP.text = hp.ToString();
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
