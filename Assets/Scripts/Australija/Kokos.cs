using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kokos : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggernEnter(Collider other)
    {
        if (other.gameObject.CompareTag("XR_RIG"))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
