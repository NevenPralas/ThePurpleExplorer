using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class GlobalMemory : MonoBehaviour
{
    public static int svi = 0;
    public static int kangaroo = 0;
    public static int emu = 0;
    public static int kazuar = 0;
    public static int kljunas = 0;
    public static int koala = 0;
    public static int pobjeda = 0; // pobjeda kada smo skupili 16!

    public static GameObject pamtiButton;

    public static GameObject pamti = null;

    public static int totemAfrika = 0;
    public static int totemAustralija = 0;
    public static int totemEuropa = 0;
    public static int totemAnt = 0;

    public static int gsAfrika = 0;
    public static int gsAustralija = 0;
    public static int gsEuropa = 0;
    public static int gsAnt = 0;


    public static int prosloVrijeme = 0;

    // Za protivnike u sobi Africa koja je zapravo Srednja Amerika koja je zapravo Sjeverna Amerika
    public static Vector3 polozaj1;
    public static Vector3 polozaj2;
    public static Vector3 polozaj3;
    public static Vector3 polozaj4;
    public static Vector3 polozaj5;

    public static bool gotovo = false;



    public static bool ponovniUlazak = false;


}
