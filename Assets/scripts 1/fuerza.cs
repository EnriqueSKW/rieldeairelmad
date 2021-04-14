using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class fuerza : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cubo;
    public GameObject Indicador;
    public GameObject referencia;
    public Vector3 velocidad = new Vector3(0,0,0);
    public Boolean goreversa = false;
    public float nextActionTime = 1.5f;
    public float period = 0.2f;


    // Update is called once per frame
    void Update()
    {


        if (Time.time > nextActionTime && goreversa == true)
        {
            nextActionTime += period;


            Instantiate(Indicador, referencia.transform.position, referencia.transform.rotation);

            GameObject.FindGameObjectWithTag("Respawn").transform.SetParent(null);
            GameObject.FindGameObjectWithTag("Respawn").tag = "Player";
        }

    }

    public void iniciargame()
    {
        Cubo.GetComponent<Rigidbody>().velocity = new Vector3(5.8f, 0, 0);
        goreversa = true;
    }

    public void restart()
    {
        SceneManager.LoadScene("asd");
    }

    void OnTriggerEnter(Collider collider)
    {
        goreversa = false;
        //Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-2, 0, 0);
        //  Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-Cubo.GetComponent<Rigidbody>().velocity.x,0,0);
        Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-5.8f, 0, 0);
    }

}
