using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IskljuciDugmeKonacno : MonoBehaviour
{
    public GameObject ploca;

    public Material material;
    // Start is called before the first frame update
    Canvas canvass;
    Renderer rendererr;

    private void Start()
    {
        canvass = GetComponentInParent<Canvas>();
        rendererr = ploca.GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!rendererr.materials[0].name.Contains("Australia"))
        {
            canvass.enabled = false;
        }
    }
}
