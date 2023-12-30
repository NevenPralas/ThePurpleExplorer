using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VratiProtivnike : MonoBehaviour
{

    public GameObject[] protivnici = new GameObject[5];

    
    public void vratiProtivnike()
    {
        if(GlobalMemory.gotovo == false)
        {
            Debug.Log("Usao1");
            GlobalMemory.gotovo = true;
            GlobalMemory.polozaj1 = protivnici[0].transform.position;
            GlobalMemory.polozaj2 = protivnici[1].transform.position;
            GlobalMemory.polozaj3 = protivnici[2].transform.position;
            GlobalMemory.polozaj4 = protivnici[3].transform.position;
            GlobalMemory.polozaj5 = protivnici[4].transform.position;
        }
        else if (GlobalMemory.gotovo == true)
        {

            Debug.Log("USAO2");
            GlobalMemory.gotovo = true;

            Curtain.cekanje = 0; PojavaEnemy.i = 0; PojavaEnemy.j = 0;

            protivnici[3].GetComponent<MeshRenderer>().enabled = false;
            protivnici[3].GetComponent<CapsuleCollider>().enabled = false;
            protivnici[4].GetComponent<MeshRenderer>().enabled = false;
            protivnici[4].GetComponent<CapsuleCollider>().enabled = false;
            protivnici[0].GetComponent<MeshRenderer>().enabled = true;
            protivnici[0].GetComponent<CapsuleCollider>().enabled = true;
            protivnici[1].GetComponent<MeshRenderer>().enabled = true;
            protivnici[1].GetComponent<CapsuleCollider>().enabled = true;
            protivnici[2].GetComponent<MeshRenderer>().enabled = true;
            protivnici[2].GetComponent<CapsuleCollider>().enabled = true;

            protivnici[0].transform.position = GlobalMemory.polozaj1;
            protivnici[1].transform.position = GlobalMemory.polozaj2;
            protivnici[2].transform.position = GlobalMemory.polozaj3;
            protivnici[3].transform.position = GlobalMemory.polozaj4;
            protivnici[4].transform.position = GlobalMemory.polozaj5;

            
            
        }
    }
}
