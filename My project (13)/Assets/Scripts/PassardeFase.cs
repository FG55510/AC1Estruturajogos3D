using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassardeFase : MonoBehaviour
{
    [SerializeField] string proximafase;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.MudaFase(proximafase);
    }
}
