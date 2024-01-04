using BNG;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmanjivanjeLoptica : MonoBehaviour
{
    public TextMeshProUGUI tekstic;

    public static int poraz = 0;

    public GameObject button;


    // Update is called once per frame
    void Update()
    {
        if(BrojanjeLoptica.brojacLoptica == 20) {
            button.SetActive(true); }
        else if (BrojanjeLoptica.brojacLoptica == 19) {
            button.SetActive(false); tekstic.text = "19/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 18) { button.SetActive(false); tekstic.text = "18/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 17) { button.SetActive(false); tekstic.text = "17/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 16) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "16/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 15) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "15/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 14) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "14/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 13) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "13/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 12) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "12/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 11) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "11/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 10) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "10/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 9) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "9/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 8) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "8/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 7) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "7/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 6) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "6/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 5) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "5/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 4) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "4/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 3) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "3/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 2) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "2/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 1) { button.SetActive(false); if (Pogodak.pogodjeno2 != 2) tekstic.text = "1/20"; }
        else if (BrojanjeLoptica.brojacLoptica == 0)
        {
            button.SetActive(false);
            if (Pogodak.pogodjeno2 != 2)
            {
                tekstic.text = "0/20";
                poraz = 1;


                StartCoroutine(CekanjeFunkcija());
            }
        };
    }

    IEnumerator CekanjeFunkcija()
    {

        yield return new WaitForSeconds(5f);

        if (Pogodak.pogodjeno2 != 2)
        {
            Pogodak.pogodjeno = 0;
            Pogodak.pogodjeno2 = 0;
            SceneManager.LoadScene("Otok");
        }
        
    }


}
