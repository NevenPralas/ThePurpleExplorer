using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pogodak : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Pogodio si!");
        }

    }
}
