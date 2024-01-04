using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UkljucivanjePuzzli : MonoBehaviour
{
    public GameObject[] puzzle = new GameObject[10];
    public GameObject[] crno = new GameObject[10];
    public void funckija()
    {
        for(int i = 0; i<10; i++)
        {
            puzzle[i].GetComponent<MeshRenderer>().enabled = true;
            puzzle[i].GetComponent<MeshCollider>().enabled = true;
            crno[i].GetComponent<Canvas>().enabled = true;

        }
    }
}
