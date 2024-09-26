using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtScore;
    public TMP_Text txtLife;
    public TMP_Text txtChave;
    public TMP_Text txtAnuncio;

    // Start is called before the first frame update
    void Start()
    {
        txtAnuncio.text = "";
    }
    public void ChangeScore(int value)
    {
        txtScore.text = "Score: " + value.ToString();
    }

    public void ChangeLife(int value)
    {
        txtLife.text = "Life: " + value.ToString();
    }

    public void ChavePega(int value, bool finalfase)
    {

        txtChave.text = "x " + value.ToString();

        if (finalfase)
        {
            txtChave.text = "O portal está aberto";
        }

    }

    public void Anuncio(string texto)
    {
        txtAnuncio.text = texto;
        StartCoroutine(Tiraranunciodatela());
    }

    private void TiraAnuncio()
    {
        txtAnuncio.text = "";
    }

    public IEnumerator Tiraranunciodatela()
    {
        yield return new WaitForSeconds(5);

        TiraAnuncio();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
