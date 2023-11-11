using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] GameObject zivotinja;

    Rigidbody rb;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    private void Start()
    {
        rb = zivotinja.GetComponent<Rigidbody>();
    }
    public void JumpF()
    {
        if (isGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }

    bool isGrounded() {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }
}
