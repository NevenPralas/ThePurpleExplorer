using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustDelete : MonoBehaviour
{
   [SerializeField] private GameObject go1;
   [SerializeField] private GameObject go2;
    [SerializeField] private GameObject go3;
    [SerializeField] private GameObject go4;
    private int index = 0;

    private void Start()
    {
        
        go2.GetComponent<MeshRenderer>().enabled = false;   
        go2.GetComponent<BoxCollider>().enabled = false;
        go4.GetComponent<MeshRenderer>().enabled = false;
        go4.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    public void Poluga()
    {
        if (index == 0) {
            go1.GetComponent<MeshRenderer>().enabled = false;
            go2.GetComponent<MeshRenderer>().enabled = true;
            go1.GetComponent<BoxCollider>().enabled = false;
            go2.GetComponent<BoxCollider>().enabled = true;
            go3.GetComponent<MeshRenderer>().enabled = false;
            go4.GetComponent<MeshRenderer>().enabled = true;
            go3.GetComponent<BoxCollider>().enabled = false;
            go4.GetComponent<BoxCollider>().enabled = true;
            index = 1;
        }
        else
        {
            go1.GetComponent<MeshRenderer>().enabled = true;
            go2.GetComponent<MeshRenderer>().enabled = false;
            go1.GetComponent<BoxCollider>().enabled = true;
            go2.GetComponent<BoxCollider>().enabled = false; 
            go3.GetComponent<MeshRenderer>().enabled = true;
            go4.GetComponent<MeshRenderer>().enabled = false;
            go3.GetComponent<BoxCollider>().enabled = true;
            go4.GetComponent<BoxCollider>().enabled = false;
            index = 0;
        }
    }

   
}
