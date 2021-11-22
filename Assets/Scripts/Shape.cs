using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Shape : MonoBehaviour
{
    [SerializeField]
    private string shapeName;
    [SerializeField]
    private float jumpHeight;

    // ENCAPSULATION
    public string ShapeName { get => shapeName; protected set => shapeName = value; }
    // ENCAPSULATION
    public float JumpHeight { get => jumpHeight; protected set => jumpHeight = value; }

    public virtual void DisplayText()
    {
        Debug.Log("Shape Name");
    }

    public virtual void Jump()
    {
        Debug.Log("shape jump");
    }
}
