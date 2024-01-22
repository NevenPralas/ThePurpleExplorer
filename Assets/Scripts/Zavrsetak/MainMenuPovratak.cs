using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPovratak : MonoBehaviour
{
    public void Click()
    {
        GlobalMemory.gsAfrika = 0;
        GlobalMemory.gsAnt = 0;
        GlobalMemory.gsAustralija = 0;
        GlobalMemory.gsEuropa = 0;

        GlobalMemory.totemAfrika = 0;
        GlobalMemory.totemAnt = 0;
        GlobalMemory.totemAustralija = 0;
        GlobalMemory.totemEuropa = 0;

        GlobalMemory.pobjeda = 0;
        GlobalMemory.svi = 0;
        GlobalMemory.koala = 0;
        GlobalMemory.kangaroo = 0;
        GlobalMemory.kazuar = 0;
        GlobalMemory.emu = 0;
        GlobalMemory.kljunas = 0;

        GlobalMemory.ponovniUlazak = false;
    }
}
