using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWhenWin : MonoBehaviour
{
    private Renderer renderer;
    private Collider BoxCollider;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        BoxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.pobjeda == 16)
        {
            renderer.enabled = false;
            BoxCollider.enabled = false;
        }
    }
}
