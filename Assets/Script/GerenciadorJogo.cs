using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EstadoDoJogo{INICIAL, JOGANDO, PAUSADO};
public class GerenciadorJogo : MonoBehaviour
{
    public EstadoDoJogo estados = EstadoDoJogo.INICIAL;
    public GameObject[] interfaceInicial;
    public GameObject gerenciadorObstaculos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJogo(){
        //desativa interface
        foreach(GameObject elem in interfaceInicial){
            elem.SetActive(false);
        }

        gerenciadorObstaculos.SetActive(true);

        //destativa gerenciador
        Debug.Log("iniciou jogo");
    }
}
