using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpColetable : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Podepular(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void Podepular(GameObject player)
    {
        player.GetComponent<Player>().enabled = true;
        player.GetComponent<PlayerMove>().enabled = false;
        GameManager.Instance.Anuncio("pulo");
    }

}
