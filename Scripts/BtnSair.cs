using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnSair : MonoBehaviour
{
    public void Menu()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("Menu");
    }
}
