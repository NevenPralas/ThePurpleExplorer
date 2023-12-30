using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nestajanje : MonoBehaviour
{
    public GameObject[] predmeti = new GameObject[12];

    // Update is called once per frame
    void Update()
    {
        if (Pogodak.pogodjeno2 == 2)
        {

            for (int i = 0; i < predmeti.Length; i++)
            {
                predmeti[i].GetComponent<MeshRenderer>().enabled = false;
                predmeti[i].GetComponent<BoxCollider>().enabled = false;
            }

        }
    }

}
