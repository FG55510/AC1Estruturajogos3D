using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoreend : MonoBehaviour
{
    public TMP_Text txtScore;
    public SO_GameData gameData;

    // Start is called before the first frame update
    void Start()
    {
        Score(gameData.score);
    }
    public void Score(int value)
    {
        txtScore.text = "Seu Score: " + value.ToString();
    }
}
