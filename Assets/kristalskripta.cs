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
        // Provjerava je li objekt s kojim je igra� do�ao u dodir kristal
        if (other.CompareTag("Crystal"))
        {
            // Uni�tava kristal
            Destroy(other.gameObject);

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
        zid.transform.Translate(Vector3.up * 5.0f);
    }
}
