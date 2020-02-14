using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnPause : MonoBehaviour
{
    public Text TxtPause;
    public GameObject QuadradoPause;
    public GameObject PauseMessage;
    public GameObject BtnRestart;
    public GameObject BtnUnpause;
    public GameObject BtnLeave;



    public void PauseGame()
    {
        TxtPause.text = "ON";
        QuadradoPause.SetActive(true);
        BtnLeave.SetActive(true);
        BtnRestart.SetActive(true);
        BtnUnpause.SetActive(true);
        PauseMessage.SetActive(true);
    }
    public void UnPauseGame()
    {
        TxtPause.text = "OFF";
        QuadradoPause.SetActive(false);
        BtnLeave.SetActive(false);
        BtnRestart.SetActive(false);
        BtnUnpause.SetActive(false);
        PauseMessage.SetActive(false);
    }
}
