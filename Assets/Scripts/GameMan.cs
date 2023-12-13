using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] crystals; // Polje koje sadr�i objekte koji predstavljaju kristale
    public GameObject[] shelves; // Polje koje sadr�i objekte koji predstavljaju police
    public GameObject[] walls;   // Polje koje sadr�i objekte koji predstavljaju zidove

    private int crystalsPlaced = 0;

    private void Start()
    {
        if (crystals.Length != shelves.Length || crystals.Length != walls.Length)
        {
            Debug.LogError("Broj kristala, polica i zidova mora biti isti.");
            return;
        }
    }

    public void PlaceCrystalOnShelf(int crystalIndex)
    {
        if (crystalIndex == crystalsPlaced)
        {
            // Postavite kristal na odgovaraju�u policu
            crystals[crystalIndex].transform.position = shelves[crystalIndex].transform.position;

            // Postavite logiku za uklanjanje zida
            RemoveWall(crystalIndex);

            crystalsPlaced++;

            if (crystalsPlaced == crystals.Length)
            {
                Debug.Log("Svi kristali su postavljeni. Otvoren je put dalje!");
            }
        }
    }

    private void RemoveWall(int wallIndex)
    {
        // Uni�tite zid na odgovaraju�em indeksu
        Destroy(walls[wallIndex]);
    }
}
