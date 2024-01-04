using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CudniPovratak : MonoBehaviour
{
    public void cudniPovratak()
    {
        Pogodak.pogodjeno = 0;
        Pogodak.pogodjeno2 = 0;
        PojavaEnemy.i = 0;
        PojavaEnemy.j = 0;
        BrojanjeLoptica.brojacLoptica = 20;
        Curtain.cekanje = 0;
    }
}
