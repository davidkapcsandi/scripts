using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeExample : MonoBehaviour // Main start, inheritence.
{
    public int myInteger;
    public float myFloat;
    public double myDouble;
    public char myChar;
    public string myString;
    public bool myBool;

    [Space(10)] // Just for visual in unity to seperate the 2

    public GameObject myGameObject; 
    public Transform myTransform;  
    public Rigidbody myRigidbody; 
}
