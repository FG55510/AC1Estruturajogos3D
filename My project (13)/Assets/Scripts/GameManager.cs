using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private SO_GameData gameData;
    public static UIManager ui;

    [SerializeField] GameObject player;
    [SerializeField] Transform respawndeath;

    public GameObject portal;
    public int chavesnecessarias;

    public int fase;
    public int score;
    public int life = 3;
    public int keys = 0;
    public bool playervida;
   

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    void Start()
    {
        ui = FindAnyObjectByType<UIManager>();
        score = gameData.score;
        fase = gameData.fase;
        ui.Changefase(fase);
        ui.ChangeScore(score);
        portal.SetActive(false);

    }

    public void SetScore(int value)
    {

        gameData.score += value;
        score = gameData.score;
        ui.ChangeScore(score);
    }

    public void MudaFase(string fase)
    {
        gameData.fase++;
        SceneManager.LoadScene(fase);
    }

    public void PlayerRespawn(Transform point)
    {
        player.transform.position = point.position;
    }


    public void Damage() {
        if (playervida)
        {
            if (life > 0) {
                life--;
            }
            else
            {
                keys = 0;
                PlayerRespawn(respawndeath);
                life = 5;
            }
        }
        PlayerRespawn(respawndeath);
    }

    private void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.E)) {
        Damage();
        }

    }


    public void Anuncio(string tipo)
    {
        switch(tipo){
            case "pulo":
                ui.Anuncio("Liberou pulo! Pressione espaço para pular!");
                break;

            case "chave":
                ui.Anuncio("Fim da fase liberado! Vá ao Portal para proxima fase!");
                break;

            case "follow":
                ui.Anuncio("Cuidado! Um inimigo está te seguindo!");
                break ;

        }
    }

    public void Habilitavida()
    {
        playervida = true;
        life = 3;
    }


    public void GetKey()
    {
        keys++;
        ui.Chaves(keys,chavesnecessarias);
        if (keys == chavesnecessarias)
        {
            portal.SetActive(true);
            Anuncio("chave");
        }       
    }
}
