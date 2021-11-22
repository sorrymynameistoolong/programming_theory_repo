using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class MySphere : Shape
{
    // ENCAPSULATION
    private Rigidbody rigidbody;
    private bool isOnGround = true;

    // ABSTRACTION
    void Start()
    {
        ShapeName = "MySphere";
        JumpHeight = 3f;

        rigidbody = GetComponent<Rigidbody>();

        DisplayText();
    }

    // POLYMORPHISM // ABSTRACTION
    public override void DisplayText()
    {
        Debug.Log("This is MySphere!");
    }

    // POLYMORPHISM  // ENCAPSULATION // ABSTRACTION
    public override void Jump()
    {
        Debug.Log("MySphere Jump");

        if (isOnGround)
        {
            rigidbody.AddForce(Vector3.up * JumpHeight, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // ABSTRACTION
    void Update()
    {

    }

    // ABSTRACTION
    void OnMouseDown()
    {
        Jump();
    }

    // ABSTRACTION
    void OnCollisionEnter(Collision collision)
    {
        if (!isOnGround && collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
