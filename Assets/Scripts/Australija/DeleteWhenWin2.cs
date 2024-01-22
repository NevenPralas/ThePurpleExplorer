using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWhenWin2 : MonoBehaviour
{

    private Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.pobjeda == 10 && GlobalMemory.ponovniUlazak == false)
        {
            canvas.enabled = false;
        }
        else
        {
            canvas.enabled = true;
        }
    }
}
