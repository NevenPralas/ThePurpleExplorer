using UnityEngine;

public class GateScript : MonoBehaviour
{
    private bool isOpen = false; // Dodajte ovo polje kako biste pratili stanje vrata
    public float liftAmount = 20f; // Dodajte ovo polje kako biste kontrolisali koliko se vrata podi�u

    public void OpenGate()
    {
        // Provera da li su vrata ve� otvorena
        if (!isOpen)
        {
            // Primer: Otvaranje vrata pomeranjem po Y osi za odre�enu visinu (liftAmount)
            transform.Translate(Vector3.up * liftAmount, Space.World);

            // Postavite isOpen na true kako biste spre�ili ponovno otvaranje
            isOpen = true;
        }
    }
}
