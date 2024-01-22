using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWhenWin : MonoBehaviour
{
    private Renderer rendererr;
    private Collider BoxCollider;

    void Start()
    {
        rendererr = GetComponent<Renderer>();
        BoxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.pobjeda == 10 && GlobalMemory.ponovniUlazak==false)
        {
            rendererr.enabled = false;
            BoxCollider.enabled = false;
        }
        else
        {
            rendererr.enabled = true;
            BoxCollider.enabled = true;
        }
    }
}
