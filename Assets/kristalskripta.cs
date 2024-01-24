using UnityEngine;

public class KristalSkripta : MonoBehaviour
{
    // Broj kristala koje imate
    public int brojKristala = 5;

    // Referenca na 3D cube koji predstavlja zid
    public GameObject zid;

    // Broja� pokupljenih kristala
    private int pokupljeniKristali = 0;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            // Uni�tava kristal
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            // Pove�ava broja� pokupljenih kristala
            pokupljeniKristali++;

            // Ako svi kristali nisu pokupljeni, pomakni zid prema gore
            if (pokupljeniKristali <= brojKristala)
            {
                PodigniZid();
            }
        }
    }

    void PodigniZid()
    {
        // Pomakni zid prema gore
        zid.transform.Translate(Vector3.up * 10f, Space.World);
    }
}
