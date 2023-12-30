using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nestajanje : MonoBehaviour
{
    public GameObject[] predmeti = new GameObject[12];
    public TextMeshProUGUI tekstic;

    bool jednom = false;

    public GameObject button1;
    public GameObject button2;

    public GameObject plakat;

    // Update is called once per frame
    void Update()
    {
        if (Pogodak.pogodjeno2 == 2)
        {

            plakat.GetComponent<Canvas>().enabled = true;

            if (GlobalMemory.totemAfrika == 0)
            {
                button1.SetActive(false);
                button2.SetActive(false);
            }
            else
            {
                button1.SetActive(true);
                button2.SetActive(true);
            }

            for (int i = 0; i < predmeti.Length; i++)
            {
                predmeti[i].GetComponent<MeshRenderer>().enabled = false;
                predmeti[i].GetComponent<BoxCollider>().enabled = false;
            }
            if (!jednom)
            {
                jednom = true;
                tekstic.text = "Nice job";
                tekstic.color = Color.green;
                StartCoroutine(CekanjeText());
            }
        }
        else if(Pogodak.pogodjeno2 != 2)
        {
           
                for (int i = 0; i < predmeti.Length; i++)
                {
                    predmeti[i].GetComponent<MeshRenderer>().enabled = true;
                    predmeti[i].GetComponent<BoxCollider>().enabled = true;
                }
            
        }
    }

    IEnumerator CekanjeText()
    {

        yield return new WaitForSeconds(3f);

        tekstic.text = " ";

    }

}
