using UnityEngine;

public class GateScript : MonoBehaviour
{
    private bool isOpen = false; // Dodajte ovo polje kako biste pratili stanje vrata
    public float liftAmount = 20f; // Dodajte ovo polje kako biste kontrolisali koliko se vrata podižu

    public void OpenGate()
    {
        // Provera da li su vrata veæ otvorena
        if (!isOpen)
        {
            // Primer: Otvaranje vrata pomeranjem po Y osi za odreðenu visinu (liftAmount)
            transform.Translate(Vector3.up * liftAmount, Space.World);

            // Postavite isOpen na true kako biste spreèili ponovno otvaranje
            isOpen = true;
        }
    }
}
