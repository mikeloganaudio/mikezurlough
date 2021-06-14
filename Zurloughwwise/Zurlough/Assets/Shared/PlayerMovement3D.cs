using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float speed = 20;
    private Vector3 motion;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        motion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.velocity = motion * speed;
    }
}
