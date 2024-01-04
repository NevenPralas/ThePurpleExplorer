using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pogodak : MonoBehaviour
{

    public static int pogodjeno = 0;

    public static int pogodjeno2 = 0;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Enemy2"))
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                pogodjeno++;
                Debug.Log(pogodjeno);

                collision.gameObject.tag = "Untagged";

                StartCoroutine(Cekanje(collision.gameObject));
            }
            else if (collision.gameObject.CompareTag("Enemy2"))
            {
                pogodjeno2++;
                Debug.Log(pogodjeno2);

                Curtain.cekanje = 0;

                collision.gameObject.GetComponent<Rigidbody>().freezeRotation = false;
                collision.gameObject.tag = "Untagged";
                collision.gameObject.GetComponent<PomicanjeEnemy>().enabled = false;

                StartCoroutine(Cekanje(collision.gameObject));

            }
            
            

        }

    }

    IEnumerator Cekanje(GameObject gameObject)
    {
        
       yield return new WaitForSeconds(2f);

        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
    }


}
