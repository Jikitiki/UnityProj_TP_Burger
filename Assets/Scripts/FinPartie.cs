using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinPartie : MonoBehaviour
{

    public GameObject gameOverUI;


    public void BouttonRejouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
    }

    public void MenuPrincipalBoutton()
    {
        SceneManager.LoadScene(0);
        gameOverUI.SetActive(false);

    }

    public void BouttonQuitter()
    {
        Application.Quit();
    }
}
