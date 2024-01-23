using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartQuiz : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Collider startPlatform;
    public GameObject quizMaster;
    public GameObject pocetak;

    public GameObject putokaz;
    public GameObject upute;

    private void OnTriggerEnter(Collider other)
    {
        quizMaster.SetActive(true);
        pocetak.SetActive(false);
        upute.SetActive(true);
        putokaz.SetActive(false);
        startPlatform.enabled = false;
    }
}
