using UnityEngine;

public class CrystalCollector : MonoBehaviour
{
    public int totalCrystals = 5;
    private int collectedCrystals = 0;

    public GameObject gate; // Postavite referencu na vrata (GATE) u inspektor prozoru

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crystal"))
        {
            Debug.Log("Crystal collected!");
            CollectCrystal(other.gameObject);
        }
    }

    private void CollectCrystal(GameObject crystal)
    {
        Debug.Log("Collecting crystal...");
        crystal.SetActive(false);
        collectedCrystals++;

        if (collectedCrystals == totalCrystals)
        {
            Debug.Log("All crystals collected. Opening gate!");
            OpenGate();
        }
    }

    private void OpenGate()
    {
        gate.SetActive(false);
        Debug.Log("Gate opened!");
    }
}