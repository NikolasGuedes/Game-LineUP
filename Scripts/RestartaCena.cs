using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartaCena : MonoBehaviour
{
   //private Scene CenaJogo;
    public Button BtnRestart;
    private string CenaJogo;
    

    // Start is called before the first frame update
    void Start()
    {
        //CenaJogo = SceneManager.GetActiveScene();
        CenaJogo = SceneManager.GetActiveScene().name;
        BtnRestart.onClick = new Button.ButtonClickedEvent();
        BtnRestart.onClick.AddListener(() => CarregarCena());
    }

    void CarregarCena()
    {
        SceneManager.LoadScene(CenaJogo);
    }

}

    
