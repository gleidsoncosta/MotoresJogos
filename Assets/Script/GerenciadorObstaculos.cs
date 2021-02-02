using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorObstaculos : MonoBehaviour
{
    public GameObject obstaculo;
    public Vector3 pos_inicial;
    public float tempoInstanciacao, cronometro;
    // Start is called before the first frame update
    void Start()
    {
        cronometro = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(cronometro > tempoInstanciacao){
            pos_inicial.x = Random.Range(-1, 2);
            Instantiate(obstaculo, pos_inicial, Quaternion.identity, this.transform);
            cronometro = 0.0f;
        }
        cronometro +=Time.deltaTime;
    }
}
