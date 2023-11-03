using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class RotacijaNaDugme : MonoBehaviour
{
    public GameObject kvadrat;
    public Material newMaterial;
    public Material oldMaterial;
    public GameObject button;

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
        else if (newMaterial.name == "Snake") GlobalMemory.snake++;
        else if (newMaterial.name == "Tapir") GlobalMemory.tapir++;
        else if (newMaterial.name == "Tasman") GlobalMemory.tasman++;

        if(GlobalMemory.svi==2 && 
            (GlobalMemory.kangaroo<2 && GlobalMemory.emu<2 &&
            GlobalMemory.kazuar<2 && GlobalMemory.kljunas<2 &&
            GlobalMemory.koala<2 && GlobalMemory.snake<2
            && GlobalMemory.tapir<2 && GlobalMemory.tasman<2)) //uvjet okrenuli 2 razlicite - Ubaciti slucaj da iskljucimo sve gumbove
        {
            button.GetComponent<MeshRenderer>().enabled = false;
            button.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine(PauseForTwoSeconds());

        }
        else if(GlobalMemory.svi==2 &&
            (GlobalMemory.kangaroo==2 || GlobalMemory.emu==2 ||
            GlobalMemory.kazuar==2 || GlobalMemory.kljunas==2 ||
            GlobalMemory.koala==2 || GlobalMemory.snake==2
            || GlobalMemory.tapir==2 || GlobalMemory.tasman==2)) //uvjet okrenuli 2 iste
        {
            ButtonDisabled();
            GlobalMemory.pobjeda += 2;
            GlobalMemory.svi = 0;
            if (GlobalMemory.kangaroo == 2) GlobalMemory.kangaroo=0;
            if(GlobalMemory.snake == 2) GlobalMemory.snake=0;
            if(GlobalMemory.tapir == 2) GlobalMemory.tapir=0;
            if(GlobalMemory.emu==2) GlobalMemory.emu=0;
            if (GlobalMemory.kazuar == 2) GlobalMemory.kazuar=0;
            if(GlobalMemory.kljunas==2) GlobalMemory.kljunas=0;
            if(GlobalMemory.koala==2) GlobalMemory.koala=0;
            if(GlobalMemory.tasman==2) GlobalMemory.tasman=0;
        }
        else if(GlobalMemory.svi==1) // uvjet okrenuli jednu
        {
            GlobalMemory.pamti = kvadrat;
            ButtonDisabled();
        }

        Debug.Log("Pobjeda: "+GlobalMemory.pobjeda+"\nSvi: "+ GlobalMemory.svi+"\nKangaroo: "+GlobalMemory.kangaroo+
            "\nEmu: "+GlobalMemory.emu+"\nKazuar: "+GlobalMemory.kazuar+"\nKljunas: "+
            GlobalMemory.kljunas+"\nKoala: "+GlobalMemory.koala+"\nSnake: "+GlobalMemory.snake+
            "\nTapir: "+GlobalMemory.tapir+"\nTasman: "+GlobalMemory.tasman);
    }

    private void ButtonDisabled()
    {
        button.GetComponent<MeshRenderer>().enabled = false;
        button.GetComponent<BoxCollider>().enabled = false;
        GlobalMemory.pamtiButton = button;
    }

    private void ButtonEnabled()
    {
        GlobalMemory.pamtiButton.GetComponent<MeshRenderer>().enabled = true;
        GlobalMemory.pamtiButton.GetComponent<BoxCollider>().enabled = true;
    }

    private IEnumerator PauseForTwoSeconds()
    {
        yield return new WaitForSeconds(2.0f);

        button.GetComponent<MeshRenderer>().enabled = true;
        button.GetComponent<BoxCollider>().enabled = true;
        ButtonEnabled();
        // Nakon 2 sekunde, nastavite s izvođenjem koda
        GlobalMemory.svi = 0;
        if (GlobalMemory.kangaroo == 1) GlobalMemory.kangaroo = 0;
        if (GlobalMemory.emu == 1) GlobalMemory.emu = 0;
        if (GlobalMemory.kazuar == 1) GlobalMemory.kazuar = 0;
        if (GlobalMemory.kljunas == 1) GlobalMemory.kljunas = 0;
        if (GlobalMemory.koala == 1) GlobalMemory.koala = 0;
        if (GlobalMemory.snake == 1) GlobalMemory.snake = 0;
        if (GlobalMemory.tapir == 1) GlobalMemory.tapir = 0;
        if (GlobalMemory.tasman == 1) GlobalMemory.tasman = 0;

        quadRenderer.material = oldMaterial;
        GlobalMemory.pamti.GetComponent<Renderer>().material = oldMaterial;
    }
}
