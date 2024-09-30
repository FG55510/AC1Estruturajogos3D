using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Cinemachine;

public class Player : MonoBehaviour
{
    public Transform freelook;
    public float force;
    public float forceJump;
    public float maxSpeed = 5f;

    Rigidbody rb;
    float hor;
    float ver;
    Vector3 direction;

    [Header("===============")]
    public float maxDistance = 1;
    public float value = 1;
    RaycastHit hit;
    public bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * forceJump);
        }
    }

    private void FixedUpdate()
    {
        Vector3 camFoward = transform.position - freelook.position;
        camFoward = new Vector3(camFoward.x, 0, camFoward.z).normalized;
        Vector3 camRight = Vector3.Cross(Vector3.up, camFoward).normalized;

        direction = camFoward * ver + camRight * hor; 
        rb.AddForce(direction * force);

        // Limitar a velocidade do jogador
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        isGrounded = Physics.SphereCast(transform.position, transform.localScale.x / 2 * value, -Vector3.up, out hit, maxDistance);
    }

    private void OnDrawGizmos()
    {
        isGrounded = Physics.SphereCast(transform.position, transform.localScale.x / 2 * value, -Vector3.up, out hit, maxDistance);

        if (isGrounded)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, -Vector3.up * maxDistance);
            Gizmos.DrawWireSphere(transform.position + (-Vector3.up * hit.distance), transform.localScale.x / 2);
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, -(Vector3.up * maxDistance + (Vector3.up * transform.localScale.x / 2)));
        }
    }
}
