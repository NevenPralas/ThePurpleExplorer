using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VratiLopteNaPocetniPolozaj : MonoBehaviour
{
    private Vector3 initialPosition;
    private Rigidbody rb;
    private bool hasMoved = false;
    private bool isInCollision = false;

    public float resetDelay = 3f;

    private int prosao = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (!hasMoved && rb.velocity.sqrMagnitude > 0.1f)
        {
            hasMoved = true;
            Invoke("CheckCollisionAndReset", resetDelay);
        }
    }

   void OnCollisionEnter(Collision collision)
    {
        if(prosao==0)
       isInCollision = true;
          
    }

    private void OnCollisionExit(Collision collision)
    {
        isInCollision = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Brojac")) { 
            isInCollision = false;
            prosao = 1;
        }
    }

    void CheckCollisionAndReset()
    {
        if (hasMoved && isInCollision)
        {
            ResetToInitialPosition();
        }
        else
        {
            hasMoved = false;
            isInCollision = false;
        }
    }

    void ResetToInitialPosition()
    {
        transform.position = initialPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        hasMoved = false;
        isInCollision = false;
    }
}
