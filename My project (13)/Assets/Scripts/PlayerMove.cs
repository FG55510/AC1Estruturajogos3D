using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using Cinemachine;


public class PlayerMove : MonoBehaviour
{
    public Transform freelook;
    public float force;
    public float maxSpeed = 5f;

    Rigidbody rb;
    float hor;
    Vector3 direction;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        hor = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector3 camFoward = transform.position - freelook.position;
        camFoward = new Vector3(camFoward.x, 0, camFoward.z).normalized;
        Vector3 camRight = Vector3.Cross(Vector3.up, camFoward).normalized;

        direction = camFoward + camRight * hor;
        rb.AddForce(direction * force);
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
