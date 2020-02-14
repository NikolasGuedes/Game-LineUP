using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MantemMusica : MonoBehaviour
{
    public GameObject ObjSom;

    void Start()
    {
        // Este método impede que o objeto 
        // atual seja destruido durante o carregamento.
        DontDestroyOnLoad(ObjSom);
    }
}
