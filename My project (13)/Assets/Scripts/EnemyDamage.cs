using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamage : MonoBehaviour
{
    
    public float speed = 2.0f;   
    public float range = 3.0f;   
    

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



    
}
