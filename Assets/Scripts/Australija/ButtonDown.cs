using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class RotacijaNaDugme : MonoBehaviour
{
    public GameObject kvadrat;
    public Material newMaterial;
    public Material oldMaterial;
    public GameObject button;

    public GameObject[] buttons = new GameObject[10];

    public int[] brojevi = new int[10];

    private Renderer quadRenderer;

    void Start()
    {
        quadRenderer = kvadrat.GetComponent<Renderer>();
    }



    public void Click()
    {
        quadRenderer.material = newMaterial;
        GlobalMemory.svi++;


        if (newMaterial.name == "Kangaroo") GlobalMemory.kangaroo++;
        else if (newMaterial.name == "Emu") GlobalMemory.emu++;
        else if (newMaterial.name == "Kazuar") GlobalMemory.kazuar++;
        else if (newMaterial.name == "Kljunas") GlobalMemory.kljunas++;
        else if (newMaterial.name == "koala") GlobalMemory.koala++;

        if (GlobalMemory.svi == 2 &&
            (GlobalMemory.kangaroo < 2 && GlobalMemory.emu < 2 &&
            GlobalMemory.kazuar < 2 && GlobalMemory.kljunas < 2 &&
            GlobalMemory.koala < 2)) //uvjet okrenuli 2 razlicite - Ubaciti slucaj da iskljucimo sve gumbove
        {

            for (int i = 0; i < buttons.Length; i++)
            {

                buttons[i].GetComponentInParent<Canvas>().enabled = false;

            }

            StartCoroutine(PauseForTwoSeconds());

        }
        else if (GlobalMemory.svi == 2 &&
            (GlobalMemory.kangaroo == 2 || GlobalMemory.emu == 2 ||
            GlobalMemory.kazuar == 2 || GlobalMemory.kljunas == 2 ||
            GlobalMemory.koala == 2)) //uvjet okrenuli 2 iste
        {
            for (int i = 0; i < buttons.Length; i++)
            {

                buttons[i].GetComponentInParent<Canvas>().enabled = false;

            }

            StartCoroutine(PauseForOneSecond());




        }
        else if (GlobalMemory.svi == 1) // uvjet okrenuli jednu
        {
            GlobalMemory.pamti = kvadrat;
            ButtonDisabled();
        }

        Debug.Log("Pobjeda: " + GlobalMemory.pobjeda + "\nSvi: " + GlobalMemory.svi + "\nKangaroo: " + GlobalMemory.kangaroo +
            "\nEmu: " + GlobalMemory.emu + "\nKazuar: " + GlobalMemory.kazuar + "\nKljunas: " +
            GlobalMemory.kljunas + "\nKoala: " + GlobalMemory.koala);
    }

    private void ButtonDisabled()
    {
        button.GetComponentInParent<Canvas>().enabled = false;
        GlobalMemory.pamtiButton = button;
    }

    private void ButtonEnabled()
    {


        GlobalMemory.pamtiButton.GetComponentInParent<Canvas>().enabled = true;

    }

    private IEnumerator PauseForTwoSeconds()
    {
        yield return new WaitForSeconds(2.0f);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponentInParent<Canvas>().enabled = true;
        }

        ButtonEnabled();
        // Nakon 2 sekunde, nastavite s izvođenjem koda
        GlobalMemory.svi = 0;
        if (GlobalMemory.kangaroo == 1) GlobalMemory.kangaroo = 0;
        if (GlobalMemory.emu == 1) GlobalMemory.emu = 0;
        if (GlobalMemory.kazuar == 1) GlobalMemory.kazuar = 0;
        if (GlobalMemory.kljunas == 1) GlobalMemory.kljunas = 0;
        if (GlobalMemory.koala == 1) GlobalMemory.koala = 0;

        quadRenderer.material = oldMaterial;
        GlobalMemory.pamti.GetComponent<Renderer>().material = oldMaterial;
    }

    private IEnumerator PauseForOneSecond()
    {

        yield return new WaitForSeconds(1.0f);

        GlobalMemory.pobjeda += 2;

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponentInParent<Canvas>().enabled = true;
        }

        ButtonDisabled();
        GlobalMemory.svi = 0;
        if (GlobalMemory.kangaroo == 2) GlobalMemory.kangaroo = 0;
        if (GlobalMemory.emu == 2) GlobalMemory.emu = 0;
        if (GlobalMemory.kazuar == 2) GlobalMemory.kazuar = 0;
        if (GlobalMemory.kljunas == 2) GlobalMemory.kljunas = 0;
        if (GlobalMemory.koala == 2) GlobalMemory.koala = 0;
    }
}
