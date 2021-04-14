using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniciarjuego : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject Cubo;
    public GameObject Indicador;
    public GameObject referencia;
    public Vector3 velocidad = new Vector3(0, 0, 0);
    public bool goreversa = false;
    private float nextActionTime = 0.0f;
    public float period = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void iniciarjuegoa()
    {
     Cubo.GetComponent<Rigidbody>().velocity = new Vector3(5.8f, 0, 0);
            goreversa = true;
    }

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

    void OnTriggerEnter(Collider collider)
    {
        goreversa = false;
        //Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-2, 0, 0);
        //  Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-Cubo.GetComponent<Rigidbody>().velocity.x,0,0);
        Cubo.GetComponent<Rigidbody>().velocity = new Vector3(-5.8f, 0, 0);
    }
}
