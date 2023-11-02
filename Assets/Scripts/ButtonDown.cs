using UnityEngine;

public class RotacijaNaDugme : MonoBehaviour
{
    public GameObject kvadrat;
    public float brzinaRotacije = 90.0f; // Brzina rotacije u stepenima po sekundi

    private bool rotacijaZapoceta = false;
    private float protekloVreme = 0.0f;

    private Quaternion pocetnaRotacija;
    private Quaternion ciljnaRotacija;

    void Start()
    {
        pocetnaRotacija = kvadrat.transform.rotation;
        ciljnaRotacija = Quaternion.Euler(0, 180, 0);
    }

    void Update()
    {
        if (rotacijaZapoceta)
        {
            protekloVreme += Time.deltaTime;
            kvadrat.transform.rotation = Quaternion.Slerp(pocetnaRotacija, ciljnaRotacija, protekloVreme / 2.0f);

            if (protekloVreme >= 2.0f)
            {
                protekloVreme = 0.0f;
                rotacijaZapoceta = false;
            }
        }
    }

    public void Click()
    {
        if (!rotacijaZapoceta)
        {
            rotacijaZapoceta = true;
        }
    }
}
