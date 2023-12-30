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

    // Update is called once per frame
    void Update()
    {
        if (BrojanjeLoptica.brojacLoptica == 19) tekstic.text = "19/20";
        else if (BrojanjeLoptica.brojacLoptica == 18) tekstic.text = "18/20";
        else if (BrojanjeLoptica.brojacLoptica == 17) tekstic.text = "17/20";
        else if (BrojanjeLoptica.brojacLoptica == 16) tekstic.text = "16/20";
        else if (BrojanjeLoptica.brojacLoptica == 15) tekstic.text = "15/20";
        else if (BrojanjeLoptica.brojacLoptica == 14) tekstic.text = "14/20";
        else if (BrojanjeLoptica.brojacLoptica == 13) tekstic.text = "13/20";
        else if (BrojanjeLoptica.brojacLoptica == 12) tekstic.text = "12/20";
        else if (BrojanjeLoptica.brojacLoptica == 11) tekstic.text = "11/20";
        else if (BrojanjeLoptica.brojacLoptica == 10) tekstic.text = "10/20";
        else if (BrojanjeLoptica.brojacLoptica == 9) tekstic.text = "9/20";
        else if (BrojanjeLoptica.brojacLoptica == 8) tekstic.text = "8/20";
        else if (BrojanjeLoptica.brojacLoptica == 7) tekstic.text = "7/20";
        else if (BrojanjeLoptica.brojacLoptica == 6) tekstic.text = "6/20";
        else if (BrojanjeLoptica.brojacLoptica == 5) tekstic.text = "5/20";
        else if (BrojanjeLoptica.brojacLoptica == 4) tekstic.text = "4/20";
        else if (BrojanjeLoptica.brojacLoptica == 3) tekstic.text = "3/20";
        else if (BrojanjeLoptica.brojacLoptica == 2) tekstic.text = "2/20";
        else if (BrojanjeLoptica.brojacLoptica == 1) tekstic.text = "1/20";
        else if (BrojanjeLoptica.brojacLoptica == 0) {
            tekstic.text = "0/20";
            if (Pogodak.pogodjeno2!=2) {
                poraz = 1;

                Pogodak.pogodjeno = 0;
                Pogodak.pogodjeno2 = 0;

                StartCoroutine(CekanjeFunkcija());
            }
        };
    }

    IEnumerator CekanjeFunkcija()
    {

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Otok");
    }
}
