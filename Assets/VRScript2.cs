using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRScript2 : MonoBehaviour
{
    public GameObject Cylinder;
    public GameObject Cube;
    public void onClick()
    {
        if (Cylinder.activeInHierarchy == true)
            Cylinder.SetActive(false);
        else
            Cylinder.SetActive(true);
    }
}
public class VRScript2 : MonoBehaviour
{

    

    private void OnMouseDown() 
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnMouseUp() 
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseEnter() 
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    private void OnMouseExit() 
    {
        Cylinder.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
