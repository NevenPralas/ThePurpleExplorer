using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PojavaEnemy : MonoBehaviour
{
    public static int i = 0; public static int j = 0;

    // Update is called once per frame
    void Update()
    {
        if (Curtain.cekanje == 1 && (i==0 || j==0))
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<CapsuleCollider>().enabled = true;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (gameObject.name == "Enemy1") i = 1 ;
            if (gameObject.name == "Enemy2") j = 1;
        }
    }
}
