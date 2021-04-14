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
    public Boolean detenercoche = false;


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
        goreversa = true;
        Cubo.GetComponent<Rigidbody>().velocity = new Vector3(190.8f, 0, 0);
      
    }

    public void restart()
    {
        SceneManager.LoadScene("rielaire");
       
    }


     private void OnTriggerEnter(Collider collider)
    {
        goreversa = false;

        Debug.Log("entre");
        //Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-2, 0, 0);
        //  Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-Cubo.GetComponent<Rigidbody>().velocity.x,0,0);
        if(detenercoche == false)
        {
             Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-190.8f, 0, 0);
             detenercoche = true;
        }
        else
        {
              Cubo.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
       
    }

}
