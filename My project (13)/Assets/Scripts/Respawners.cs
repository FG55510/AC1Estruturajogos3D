using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawners : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.SetRespawn(transform);
    }
}
