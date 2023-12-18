using UnityEngine;

public class CrystalScript : MonoBehaviour
{
    public GameObject linkedGate; // Postavite ovo u Unity editoru povezivanjem vrata s kristalom

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ako igraè dodirne kristal
        {
            CollectCrystal();
        }
    }

    private void CollectCrystal()
    {
        // Onemoguæi render kristala i collider
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // Otvara vrata povezana s ovim kristalom
        if (linkedGate != null)
        {
            linkedGate.GetComponent<GateScript>().OpenGate();
        }
    }
}
