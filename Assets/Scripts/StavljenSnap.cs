using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StavljenSnap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 2)
        {
            if(transform.GetChild(0).name=="totemAfrika" || transform.GetChild(1).name == "totemAfrika")
            {
                GlobalMemory.totemAfrika = 1;
            }
            else
            {
                GlobalMemory.totemAfrika = 0;
            }
            if (transform.GetChild(0).name == "totemAustralija" || transform.GetChild(1).name == "totemAustralija")
            {
                GlobalMemory.totemAustralija = 1;
            }
            else
            {
                GlobalMemory.totemAustralija = 0;    
            }
            if (transform.GetChild(0).name == "totemEuropa" || transform.GetChild(1).name == "totemEuropa")
            {
                GlobalMemory.totemEuropa = 1;
            }
            else
            {
                GlobalMemory.totemEuropa = 0;
            }
        }
        else
        {
            GlobalMemory.totemAfrika = 0;
            GlobalMemory.totemAustralija = 0;
            GlobalMemory.totemEuropa = 0;
        }
    }
}
