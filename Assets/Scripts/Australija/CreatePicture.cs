using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePicture : MonoBehaviour
{
    [SerializeField] Material[] materials = new Material[10];

    private List<int> moguciBrojevi;
    
    // Start is called before the first frame update
    void Start()
    {
        InicijalizirajMoguceBrojeve();

        RotacijaNaDugme[] djeca = GetComponentsInChildren<RotacijaNaDugme>();

        int k = 0;

        for(int i = 0; i<10; i++)
        {
            if (moguciBrojevi.Count == 0) break;
            int odabraniBroj = OdaberiSlucajniBroj();
            Debug.Log(odabraniBroj);
            moguciBrojevi.Remove(odabraniBroj);

            djeca[k].newMaterial = materials[odabraniBroj];
            k++;
        }
    }

    void InicijalizirajMoguceBrojeve()
    {
        moguciBrojevi = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            moguciBrojevi.Add(i);
        }
    }

    int OdaberiSlucajniBroj()
    {
        int indeks = Random.Range(0, moguciBrojevi.Count);
        return moguciBrojevi[indeks];
    }


}
