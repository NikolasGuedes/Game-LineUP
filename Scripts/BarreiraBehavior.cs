using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreiraBehavior : MonoBehaviour
{

    public float VelBarreira;

    // Start is called before the first frame update
    void Start()
    {
        VelBarreira = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -VelBarreira * Time.deltaTime, 0));
    }

    public void OnTriggerEnter2D(Collider2D Outro)
    {

        if (Outro.gameObject.CompareTag("DestroiObstaculos"))
        {
            Destroy(this.gameObject);
        }
    }
}
