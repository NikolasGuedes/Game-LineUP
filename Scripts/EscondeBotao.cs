using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscondeBotao : MonoBehaviour
{


    public Text TxtStatusJogador;
    public GameObject BtnPause;


    // Update is called once per frame
    void Update()
    {
        if(TxtStatusJogador.text == "false")
        {
            BtnPause.SetActive(false);
        }
    }
}
