using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float speed = 2.0f;   // Speed of movement
    public float range = 3.0f;   // How far left and right to move

    private Vector3 startPosition;

    void Start()
    {
        
        startPosition = transform.position;
    }

    void Update()
    {
        
        float newX = startPosition.x + Mathf.Sin(Time.time * speed) * range;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            GameManager.Instance.Damage();
        }
    }
}
