using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_regla : MonoBehaviour
{
    public Vector3 mOffset;
    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
        //transform.SetParent(null);
    }


    private void OnMouseDrag()
    {

        transform.position = GetMouseWorldPos() + mOffset;
        gameObject.tag = "Arrastrando";

    }



    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }


    private void OnMouseOver()
    {
        //print(gameObject.name);
    }


    private void OnMouseUp()
    {
       // gameObject.tag = "Soltado";
        //print("Clicsobre Objeto");
        //gameObject.tag = "Player";
    }
}
