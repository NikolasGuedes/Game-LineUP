using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnObstaculos : MonoBehaviour
{
    public GameObject ObstaculoVerde;
    public GameObject ObstaculoAmarelo;
    public GameObject ObstaculoVermelho;
    public GameObject RespawnObstaculo;
    public int NumeroAleatorio;
    public float Contador;
    public float NumeroVel;
    public Text TxtPontosJogador;
    public int PontosJogador;

    // Start is called before the first frame update
    void Start()
    {
        NumeroVel = 1f; 
        //NumeroVel = 5f;
        Contador = NumeroVel;
    }

    // Update is called once per frame
    void Update()
    {
        PontosJogador = int.Parse(TxtPontosJogador.text);
        Contador -= 1f * Time.deltaTime;

        if(Contador <= 0)
        {
            NumeroAleatorio = Random.Range(0, 3);

            if(NumeroAleatorio == 0)
            {
                Instantiate(ObstaculoVerde, new Vector3(RespawnObstaculo.transform.position.x, RespawnObstaculo.transform.position.y, RespawnObstaculo.transform.position.z), Quaternion.identity);
            }
            if (NumeroAleatorio == 1)
            {
                Instantiate(ObstaculoAmarelo, new Vector3(RespawnObstaculo.transform.position.x, RespawnObstaculo.transform.position.y, RespawnObstaculo.transform.position.z), Quaternion.identity);
            }
            if (NumeroAleatorio == 2)
            {
                Instantiate(ObstaculoVermelho, new Vector3(RespawnObstaculo.transform.position.x, RespawnObstaculo.transform.position.y, RespawnObstaculo.transform.position.z), Quaternion.identity);
            }
            Contador = NumeroVel;
        }

        if(PontosJogador >= 10)
        {
            NumeroVel = 0.8f;
            //NumeroVel = 4f;

        }

        if (PontosJogador >= 20)
        {
            NumeroVel = 0.6f;
            //NumeroVel = 3f;
        }

        if (PontosJogador >= 25)
        {
            NumeroVel = 0.5f;
            //NumeroVel = 2f;
        }

        if (PontosJogador >= 40)
        {
            NumeroVel = 0.4f;
            //NumeroVel = 1f;
        }
    }
}
