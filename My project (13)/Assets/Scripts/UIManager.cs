using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtScore;
    public TMP_Text txtChave;
    public TMP_Text txtAnuncio;
    public TMP_Text txtfase;

    // Start is called before the first frame update
    void Start()
    {
        txtAnuncio.text = "";
    }

    public void Changefase(int value)
    {
        txtfase.text = "Fase: " + value.ToString() +"/3";
    }
    public void ChangeScore(int value)
    {
        txtScore.text = "Score: " + value.ToString();
    }


    public void Chaves(int value, int max)
    {

        txtChave.text = "crystais: " + value.ToString() + "/" + max.ToString();

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
