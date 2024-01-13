using UnityEngine;

public class GibanjeEnd : MonoBehaviour
{
    public float brzinaKretanja = 5.0f;

    void Update()
    {
        Vector3 trenutnaPozicija = transform.position;

        float pomak = brzinaKretanja * Time.deltaTime;

        trenutnaPozicija.z -= pomak;

        transform.position = trenutnaPozicija;
    }
}
