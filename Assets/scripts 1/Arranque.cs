using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arranque : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         GameObject.Find("Directional Light").transform.eulerAngles = new Vector3(68,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
