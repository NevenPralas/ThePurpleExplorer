using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakniBoxCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalMemory.pobjeda == 10)
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
