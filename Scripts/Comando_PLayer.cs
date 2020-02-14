using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Comando_PLayer : MonoBehaviour
{
    //private bool AdsUmaVez = false;


    public GameObject LocVerde;
    public GameObject LocAmarela;
    public GameObject LocVermelha;
    public Text  TxtLinhaJogador;
    public Text TxtStatusJogador;
    public Text TxtPontosJogador;
    public Text TxtLadoApertado;
    public Text TxtPosicao;
    public GameObject Player;
    public int PontosJogador;
    public float Vel;
    public GameObject BtnRetry;
    public GameObject BtnSair;
    public GameObject SomAcertoVerde;
    public GameObject SomAcertoAmarelo;
    public GameObject SomAcertoVermelho;
    public GameObject SomErro;
    public Text TxtLibera;
    public GameObject QuadradoItsOver;
    public Text TxtScore;
    public Text TxtBestScore;
    public GameObject NewRecord;

    public int scoreAtualDoNivel;
    public int scoreMaximoSalvo;
    string nomeDaCena;

    public int BestScore;
    public int Score;



    // Start is called before the first frame update
    void Start()
    {
        scoreAtualDoNivel = 0;
        scoreMaximoSalvo = 0;
        nomeDaCena = SceneManager.GetActiveScene().name;
        //reseta score
        // PlayerPrefs.DeleteKey (nomeDaCena + "score");
        if (PlayerPrefs.HasKey(nomeDaCena + "score"))
        {
            scoreMaximoSalvo = PlayerPrefs.GetInt(nomeDaCena + "score");
        }


        Vel = 100f;
        PontosJogador = 0;
        BtnRetry.SetActive(false);
        BtnSair.SetActive(false);
        TxtLibera.text = "false";
        TxtBestScore.enabled = false;
        TxtScore.enabled = false;
        QuadradoItsOver.SetActive(false);
        NewRecord.SetActive(false);
        TxtStatusJogador.text = "true";
    }


    IEnumerator Confere()
    {
        yield return new WaitForSeconds (0.01f);
        TxtLibera.text = "false";
    }

    IEnumerator LiberaBotoes()
    {
        yield return new WaitForSeconds(17f * Time.deltaTime);
        TxtBestScore.enabled = true;
        TxtScore.enabled = true;
        BtnRetry.SetActive(true);
        BtnSair.SetActive(true);        
        Player.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {


        scoreAtualDoNivel = PontosJogador;
        TxtScore.text = scoreAtualDoNivel.ToString();
        TxtBestScore.text = scoreMaximoSalvo.ToString();

        Score = int.Parse(TxtScore.text);
        BestScore = int.Parse(TxtBestScore.text);

        if(BestScore < Score)
        {
            TxtBestScore.text = Score.ToString();
            NewRecord.SetActive(true);
        }
        else
        {

        }

        if (Player.transform.position.x == LocAmarela.transform.position.x)
        {
            TxtLinhaJogador.text = "Amarelo";
            TxtPosicao.text = "Meio";
            StartCoroutine("Confere");
        }


        if (Player.transform.position.x == LocVerde.transform.position.x)
        {
            TxtLinhaJogador.text = "Verde";
            TxtPosicao.text = "Esquerda";
            StartCoroutine("Confere");
        }


        if (Player.transform.position.x == LocVermelha.transform.position.x)
        {
            TxtLinhaJogador.text = "Vermelho";
            TxtPosicao.text = "Direita";
            StartCoroutine("Confere");
        }


       

        if (TxtLadoApertado.text == "Direita" && TxtLinhaJogador.text == "Verde" && TxtLibera.text == "true" )
        {
            Vector3 PosicaoLinhaAmarela = new Vector3(LocAmarela.transform.position.x, LocAmarela.transform.position.y, LocAmarela.transform.position.z);
            transform.position = Vector3.Lerp(transform.position, PosicaoLinhaAmarela, Vel * Time.deltaTime);
        }

        if (TxtLadoApertado.text == "Direita" && TxtLinhaJogador.text == "Amarelo" && TxtLibera.text == "true")
        {
            Vector3 PosicaoLinhaVermelha = new Vector3(LocVermelha.transform.position.x, LocVermelha.transform.position.y, LocVermelha.transform.position.z);
            transform.position = Vector3.Lerp(transform.position, PosicaoLinhaVermelha, Vel * Time.deltaTime);
        }

        if (TxtLadoApertado.text == "Direita" && TxtLinhaJogador.text == "Vermelho" && TxtLibera.text == "true")
        {
            this.gameObject.transform.position = new Vector3(LocVermelha.transform.position.x, LocVermelha.transform.position.y, LocVermelha.transform.position.z);
        }

        if (TxtLadoApertado.text == "Esquerda" && TxtLinhaJogador.text == "Vermelho" && TxtLibera.text == "true")
        {
            Vector3 PosicaoLinhaAmarela = new Vector3(LocAmarela.transform.position.x, LocAmarela.transform.position.y, LocAmarela.transform.position.z);
            transform.position = Vector3.Lerp(transform.position, PosicaoLinhaAmarela, Vel * Time.deltaTime);
        }

        if (TxtLadoApertado.text == "Esquerda" && TxtLinhaJogador.text == "Amarelo" && TxtLibera.text == "true")
        {
            Vector3 PosicaoLinhaVerde = new Vector3(LocVerde.transform.position.x, LocVerde.transform.position.y, LocVerde.transform.position.z);
            transform.position = Vector3.Lerp(transform.position, PosicaoLinhaVerde, Vel * Time.deltaTime);
        }

        if (TxtLadoApertado.text == "Esquerda" && TxtLinhaJogador.text == "Verde" && TxtLibera.text == "true")
        {
            this.gameObject.transform.position = new Vector3(LocVerde.transform.position.x, LocVerde.transform.position.y, LocVerde.transform.position.z);
        }
    }


        public void OnTriggerEnter2D(Collider2D Outro)
    {

        if (Outro.gameObject.CompareTag("Verde"))
        {
           if(TxtLinhaJogador.text == "Verde")
            {
                PontosJogador += 1;
                TxtPontosJogador.text = PontosJogador.ToString();
                Instantiate(SomAcertoVerde, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);

            }

            else
            {
                TxtStatusJogador.text = "false";
                ChecarScore();
                StartCoroutine("LiberaBotoes");
                QuadradoItsOver.SetActive(true);
                Instantiate(SomErro, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                //if(AdsUmaVez == false)
                //{
                //    AdsUnity.instance.showAds();
                //    AdsUmaVez = true;
                //}
            }
        }

        if (Outro.gameObject.CompareTag("Amarelo"))
        {
            if (TxtLinhaJogador.text == "Amarelo")
            {
                PontosJogador += 1;
                TxtPontosJogador.text = PontosJogador.ToString();
                Instantiate(SomAcertoAmarelo, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
            }

            else
            {
                TxtStatusJogador.text = "false";
                ChecarScore();
                StartCoroutine("LiberaBotoes");
                QuadradoItsOver.SetActive(true);
                Instantiate(SomErro, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                //if(AdsUmaVez == false)
                //{
                //    AdsUnity.instance.showAds();
                //    AdsUmaVez = true;
                //}
            }
        }

        if (Outro.gameObject.CompareTag("Vermelho"))
        {
            if (TxtLinhaJogador.text == "Vermelho")
            {
                PontosJogador += 1;
                TxtPontosJogador.text = PontosJogador.ToString();
                Instantiate(SomAcertoVermelho, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
            }

            else
            {
                TxtStatusJogador.text = "false";
                ChecarScore();
                StartCoroutine("LiberaBotoes");
                QuadradoItsOver.SetActive(true);
                Instantiate(SomErro, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                //if(AdsUmaVez == false)
                //{
                //    AdsUnity.instance.showAds();
                //    AdsUmaVez = true;
                //}
            }
        }
    }

    void ChecarScore()
    {
        if (scoreAtualDoNivel > scoreMaximoSalvo)
        {
            scoreMaximoSalvo = scoreAtualDoNivel;
            PlayerPrefs.SetInt(nomeDaCena + "score", scoreMaximoSalvo);
        }
    }

}
