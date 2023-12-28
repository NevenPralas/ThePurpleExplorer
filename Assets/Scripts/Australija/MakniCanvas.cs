using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakniCanvas : MonoBehaviour
{
     
    

    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.pobjeda == 10)
        {
            GetComponent<Canvas>().enabled = false;
        }
    }
}
