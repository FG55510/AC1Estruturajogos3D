using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
        public Transform target; // The object to follow
        public float speed = 5f; // Speed of the follower
        public float stoppingDistance = 1f; // Distance to stop before the target

        void Update()
        {
            if (target == null)
                return;

            // Calculate the distance to the target
            float distance = Vector3.Distance(transform.position, target.position);

            // Check if we are within stopping distance
            if (distance > stoppingDistance)
            {
                // Move towards the target
                Vector3 direction = (target.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;
            }
        }

}
