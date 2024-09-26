using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximaFase : MonoBehaviour
{
    [SerializeField] string fase;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.MudaFase(fase);
        }
    }
}
