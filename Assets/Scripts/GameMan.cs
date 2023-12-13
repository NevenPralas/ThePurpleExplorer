using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] crystals; // Polje koje sadrži objekte koji predstavljaju kristale
    public GameObject[] shelves; // Polje koje sadrži objekte koji predstavljaju police
    public GameObject[] walls;   // Polje koje sadrži objekte koji predstavljaju zidove

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
            // Postavite kristal na odgovarajuæu policu
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
        // Uništite zid na odgovarajuæem indeksu
        Destroy(walls[wallIndex]);
    }
}
