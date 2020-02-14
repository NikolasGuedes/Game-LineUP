using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComecarJogo : MonoBehaviour
{

    public GameObject MesssageLeave;
    public GameObject BtnYes;
    public GameObject BtnNo;
    public Text TxtPause;
    public GameObject QuadradoPause;
    public GameObject PauseMessage;
    public GameObject BtnRestart;
    public GameObject BtnUnpause;
    public GameObject BtnLeave;
    public GameObject LogoGame;

    void Start()
    {
        
    }

    public void Game()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("Jogo");
    }

    public void Menu()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("Menu");
    }

    public void Config()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("Config");
    }

    public void Rules()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("Rules");
    }

    public void MessageLeave()
    {//Chama no Onclick do botao de jogar

        MesssageLeave.SetActive(true);
        BtnNo.SetActive(true);
        BtnYes.SetActive(true);
        LogoGame.SetActive(false);
    }

    public void CloseMessage()
    {//Chama no Onclick do botao de jogar

        MesssageLeave.SetActive(false);
        BtnNo.SetActive(false);
        BtnYes.SetActive(false);
        LogoGame.SetActive(true);
    }

    public void CloseGame()
    {//Chama no Onclick do botao de jogar

        Application.Quit();
    }




}
