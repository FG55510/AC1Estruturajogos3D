using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipocoletavel
{
    Key,
    Score,
    Powerup
}
public class Coletaveis : MonoBehaviour
{
    public Tipocoletavel tipo;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (tipo)
            {
                case Tipocoletavel.Key:
                    GameManager.Instance.GetKey();
                    break;
                case Tipocoletavel.Score:
                    GameManager.Instance.SetScore(1);
                    break;
                case Tipocoletavel.Powerup:
                    GameManager.Instance.PlayerJump();
                    break;

            }
            Destroy(gameObject);

        }

    }
}
