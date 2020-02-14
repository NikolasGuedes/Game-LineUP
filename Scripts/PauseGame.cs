using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseGame : MonoBehaviour
{
    public Text TxtPause;
    public GameObject BtnPause;
    public GameObject Player;

    void Pause()
    {
        Time.timeScale = 0;
    }

    void UnPause()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        



        if (TxtPause.text == "ON")
        {
            Time.timeScale = 0;
            BtnPause.SetActive(false);
        }
        else
        {
            TxtPause.text = "OFF";
            Time.timeScale = 1;
            BtnPause.SetActive(true);
        }

        
    }
}
