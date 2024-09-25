using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    //public SO_GameData gameData;
    public static UIManager ui;
    //public NextFase ff;
    [SerializeField] GameObject player;
    [SerializeField] Transform respawndeath;
    [SerializeField] Transform respawnvida;



    
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
    public void LoadScene(string Fase)
    {
        SceneManager.LoadScene(Fase);
    }
    // Start is called before the first frame update
    void Start()
    {
        ui = FindAnyObjectByType<UIManager>();
      //  score = gameData.score;

    }

    public void SetScore(int value)
    {

       // gameData.score += value;
        //score = gameData.score;
        ui.ChangeScore(score);
    }

    public void PlayerJump()
    {
        player.GetComponent<Player>().enabled = true;
        player.GetComponent<PlayerMove>().enabled = false;
    }

    public void MudaFase(string fase)
    {
        SceneManager.LoadScene(fase);
    }

    public void PlayerRespawn(Transform point)
    {
        player.transform.position = point.position;
    }

    public void SetRespawn(Transform respawnpoint)
    {
        respawnvida = respawnpoint;
    }

    public void Damage() {
        if (playervida)
        {
            if (life > 0) {
                if (respawnvida = null)
                {
                    respawnvida = respawndeath;
                }
                PlayerRespawn(respawnvida);
                life--;
            }
            else
            {
                keys = 0;
                PlayerRespawn(respawndeath);
            }
        }
        PlayerRespawn(respawndeath);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)) {
            PlayerJump();          
        }
        if(Input.GetKeyUp(KeyCode.E)) {
        Damage();
        }
    }

    public void Habilitavida()
    {
        playervida = true;
        life = 3;
    }


    public void GetKey()
    {
        ui.ChavePega();
       // ff.enabled = true;
    }
}
