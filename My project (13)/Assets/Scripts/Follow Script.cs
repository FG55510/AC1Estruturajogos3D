using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float speed;
    [SerializeField] private Transform inicio;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position, speed).normalized;
        if (Vector3.Distance(transform.position, Player.position) <= 0)
        {
            Debug.LogWarning("Tocou");
        }

    }
}
