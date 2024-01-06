using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrojanjeLoptica : MonoBehaviour
{
    public static int brojacLoptica = 20;

    private bool loptica1 = false;
    private bool loptica2 = false;
    private bool loptica3 = false;
    private bool loptica4 = false;
    private bool loptica5 = false;
    private bool loptica6 = false;
    private bool loptica7 = false;
    private bool loptica8 = false;
    private bool loptica9 = false;
    private bool loptica10 = false;
    private bool loptica11 = false;
    private bool loptica12 = false;
    private bool loptica13 = false;
    private bool loptica14 = false;
    private bool loptica15 = false;
    private bool loptica16 = false;
    private bool loptica17 = false;
    private bool loptica18 = false;
    private bool loptica19 = false;
    private bool loptica20 = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lopta1" && loptica1 == false)
        {
            loptica1 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta2" && loptica2 == false)
        {
            loptica2 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta3" && loptica3 == false)
        {
            loptica3 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta4" && loptica4 == false)
        {
            loptica4 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta5" && loptica5 == false)
        {
            loptica5 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta6" && loptica6 == false)
        {
            loptica6 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta7" && loptica7 == false)
        {
            loptica7 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta8" && loptica8 == false)
        {
            loptica8 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta9" && loptica9 == false)
        {
            loptica9 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta10" && loptica10 == false)
        {
            loptica10 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta11" && loptica11 == false)
        {
            loptica11 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta12" && loptica12 == false)
        {
            loptica12 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta13" && loptica13 == false)
        {
            loptica13 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta14" && loptica14 == false)
        {
            loptica14 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta15" && loptica15 == false)
        {
            loptica15 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta16" && loptica16 == false)
        {
            loptica16 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta17" && loptica17 == false)
        {
            loptica17 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta18" && loptica18 == false)
        {
            loptica18 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta19" && loptica19 == false)
        {
            loptica19 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta20" && loptica20 == false)
        {
            loptica20 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
    }

    IEnumerator CekanjeFunkcija(GameObject gameObject)
    {

        yield return new WaitForSeconds(4f);

        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<SphereCollider>().enabled = false;
    }

}
