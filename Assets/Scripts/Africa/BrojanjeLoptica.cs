using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrojanjeLoptica : MonoBehaviour
{
    public static int brojacLoptica = 20;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Loptica"))
        {
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
