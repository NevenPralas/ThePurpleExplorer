using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakniKartice : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.pobjeda == 10)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<MeshCollider>().enabled = true;

        }
    }
}
