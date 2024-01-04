using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain : MonoBehaviour
{
    public GameObject[] objects = new GameObject[7];
    public int k = 0;

    public static int cekanje = 0;

    public void otvaranjeC()
    {
        StartCoroutine(AnimateObjects(0, 6));
    }

    IEnumerator AnimateObjects(int startIdx, int endIdx)
    {
        for (int i = startIdx; i <= endIdx; i++)
        {
            objects[i].GetComponent<MeshRenderer>().enabled = false;
            objects[i].GetComponent<BoxCollider>().enabled = false;

            if(i == 0 || i%2==0)
            yield return new WaitForSeconds(1f);
        }
    }

    private void Update()
    {
        
        if(Pogodak.pogodjeno == 3)
        {
            Debug.Log("Usao");
            StartCoroutine(Sklapanje(0, 6));

        }
        
        if (k == 1)
        {
            StartCoroutine(AnimateObjects2(0, 6));
        }
    }

    IEnumerator Sklapanje(int startIdx, int endIdx)
    {
        Pogodak.pogodjeno = 0;
        for (int i = endIdx; i >= startIdx; i--)
        {
            objects[i].GetComponent<MeshRenderer>().enabled = true;
            objects[i].GetComponent<BoxCollider>().enabled = true;

            if (i % 2 == 1)
                yield return new WaitForSeconds(1f);
            if (i == 0) k++;
        }
    }

    IEnumerator AnimateObjects2(int startIdx, int endIdx)
    {
        for (int i = startIdx; i <= endIdx; i++)
        {
            if (i == 0)
            {
                yield return new WaitForSeconds(3f);
                cekanje = 1;
                k = 0;
                objects[i].GetComponent<MeshRenderer>().enabled = false;
                objects[i].GetComponent<BoxCollider>().enabled = false;
                yield return new WaitForSeconds(1f);

            }
            else
            {
                objects[i].GetComponent<MeshRenderer>().enabled = false;
                objects[i].GetComponent<BoxCollider>().enabled = false;
                if (i % 2 == 0)
                    yield return new WaitForSeconds(1f);
            }
           
        }
    }


}