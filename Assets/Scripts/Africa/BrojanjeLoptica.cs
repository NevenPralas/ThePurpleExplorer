using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrojanjeLoptica : MonoBehaviour
{
    public static int brojacLoptica = 20;

    private bool lopta1 = false;
    private bool lopta2 = false;
    private bool lopta3 = false;   
    private bool lopta4 = false;
    private bool lopta5 = false;
    private bool lopta6 = false;
    private bool lopta7 = false;
    private bool lopta8 = false;
    private bool lopta9 = false;
    private bool lopta10 = false;
    private bool lopta11 = false;
    private bool lopta12 = false;
    private bool lopta13 = false;
    private bool lopta14 = false;
    private bool lopta15 = false;
    private bool lopta16 = false;
    private bool lopta17 = false;
    private bool lopta18 = false;
    private bool lopta19 = false;
    private bool lopta20 = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lopta1" && lopta1 == false)
        {
            lopta1 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if(other.gameObject.name == "Lopta2" && lopta2 == false)
        {
            lopta2 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta3" && lopta3 == false)
        {
            lopta3 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta4" && lopta4 == false)
        {
            lopta4 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta5" && lopta5 == false)
        {
            lopta5 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta6" && lopta6 == false)
        {
            lopta6 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta7" && lopta7 == false)
        {
            lopta7 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta8" && lopta8 == false)
        {
            lopta8 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta9" && lopta9 == false)
        {
            lopta9 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta10" && lopta10 == false)
        {
            lopta10 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta11" && lopta11 == false)
        {
            lopta11 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta12" && lopta12 == false)
        {
            lopta12 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta13" && lopta13 == false)
        {
            lopta13 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta14" && lopta14 == false)
        {
            lopta14 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta15" && lopta15 == false)
        {
            lopta15 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta16" && lopta16 == false)
        {
            lopta16 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta17" && lopta17 == false)
        {
            lopta17 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta18" && lopta18 == false)
        {
            lopta18 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta19" && lopta19 == false)
        {
            lopta19 = true;
            brojacLoptica--;
            Debug.Log("Ostalo loptica: " + brojacLoptica);
            StartCoroutine(CekanjeFunkcija(other.gameObject));
        }
        else if (other.gameObject.name == "Lopta20" && lopta20 == false)
        {
            lopta20 = true;
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
