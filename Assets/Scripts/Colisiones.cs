using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colisiones : MonoBehaviour
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
        }
        
        if (tag.Equals("PowerUp"))
        {
            hp++;
            HP.text = hp.ToString();
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        string tag = collision.gameObject.tag;

        Debug.Log("Colision con: " + tag);

        if (tag.Equals("PowerUp"))
        {
            hp++;
            HP.text = hp.ToString();
        }
    }

    private void OnCollisionExit(Collision collision)
    {

    }


    //corrutina
    IEnumerator corrutinaVida() {
        while (true)
        {

            hp-=5;
            HP.text = hp.ToString();
            yield return new WaitForSeconds(1.0f);
        }
    }

}
