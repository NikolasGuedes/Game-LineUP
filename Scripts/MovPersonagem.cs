using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovPersonagem : MonoBehaviour
{
    public Text TxtLadoApertado;
    public Text TxtLibera;

    public void LadoEsquerdo()
    {//Chama no Onclick do botao de jogar

        TxtLadoApertado.text = "Esquerda";
        TxtLibera.text = "true";
    }

    public void LadoDireto()
    {//Chama no Onclick do botao de jogar

        TxtLadoApertado.text = "Direita";
        TxtLibera.text = "true";
    }
}
