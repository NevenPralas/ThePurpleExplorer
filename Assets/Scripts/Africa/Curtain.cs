using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain : MonoBehaviour
{
    public GameObject[] objects = new GameObject[7];

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
}