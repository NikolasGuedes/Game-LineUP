using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiSom : MonoBehaviour
{
    private float tempo = 2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo - Time.deltaTime;

        if (tempo <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
