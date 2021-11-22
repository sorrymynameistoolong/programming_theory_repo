using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class MyCube : Shape
{
    // ENCAPSULATION
    private Rigidbody rigidbody;
    private bool isOnGround = true;

    // ABSTRACTION
    void Start()
    {
        ShapeName = "MyCube";
        JumpHeight = 5f;

        rigidbody = GetComponent<Rigidbody>();

        DisplayText();
    }

    // POLYMORPHISM // ABSTRACTION
    public override void DisplayText()
    {
        Debug.Log("This is MyCube!");
    }

    // POLYMORPHISM  // ENCAPSULATION // ABSTRACTION
    public override void Jump()
    {
        Debug.Log("MyCube Jump");

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
