using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DugmePojava : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.gsEuropa == 1 && GlobalMemory.gsAfrika == 1 &&
            GlobalMemory.gsAnt == 1 && GlobalMemory.gsAustralija == 1)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
