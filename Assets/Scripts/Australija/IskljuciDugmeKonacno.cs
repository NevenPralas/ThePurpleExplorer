using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IskljuciDugmeKonacno : MonoBehaviour
{
    public GameObject ploca;

    public Material material;
    // Start is called before the first frame update
    Renderer rendererr;

    private void Start()
    {
        rendererr = ploca.GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!rendererr.materials[0].name.Contains("Australia"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
