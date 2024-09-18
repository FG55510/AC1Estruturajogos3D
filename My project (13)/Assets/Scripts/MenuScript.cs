using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string Startingscene;
    public void StartGame()
    {
        SceneManager.LoadScene(Startingscene);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
