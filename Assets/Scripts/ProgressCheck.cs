using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ProgressCheck : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI progresstxt;

    public int progress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress = 0;
        if(GlobalMemory.totemAustralija == 1) progress++;
        if(GlobalMemory.totemAfrika == 1) progress++;
        if(GlobalMemory.totemEuropa == 1) progress++;
        if (GlobalMemory.totemAnt == 1) progress++;
        progresstxt.text = "Progress: " + progress + "/7";
    }
}
