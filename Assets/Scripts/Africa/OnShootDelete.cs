using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnShootDelete : MonoBehaviour
{
    public GameObject[] gameObjects;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.Equals(gameObjects[0]) || collision.Equals(gameObjects[1])
            || collision.Equals(gameObjects[2] || collision.Equals(gameObjects[3]))
            || collision.Equals(gameObjects[4]) || collision.Equals(gameObjects[5])
            || collision.Equals(gameObjects[6]) || collision.Equals(gameObjects[7])
            || collision.Equals(gameObjects[8]) || collision.Equals(gameObjects[9])
            || collision.Equals(gameObjects[10]) || collision.Equals(gameObjects[11]))
        {
           GetComponent<MeshRenderer>().enabled = false;
           GetComponent<CapsuleCollider>().enabled = false;
        }
    }
  
}
