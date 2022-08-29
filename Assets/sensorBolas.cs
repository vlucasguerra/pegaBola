using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensorBolas : MonoBehaviour {

public int pontos = 0;
 public UnityEngine.UI.Text pontosDisplay;
 public UnityEngine.UI.Text tempoJogo;
 public UnityEngine.UI.Text resultado;

    void Start(){
        pontosDisplay.text = "Pontos:";

    }

    void OnTriggerEnter(Collider collision) {


            if (collision.gameObject.tag=="bola vermelha") {
                collision.gameObject.SetActive(false);
                // Debug.Log("Bola vermelha DESATIVADA");
                pontos=pontos+3;
                pontosDisplay.text = "Pontos:"+pontos;
                Debug.Log("pontos:"+pontos);

            }

            if (collision.gameObject.tag=="bola azul") {
                collision.gameObject.SetActive(false);
                // Debug.Log("Bola azul DESATIVADA");
                pontos=pontos+6;
                pontosDisplay.text = "Pontos:"+pontos;
                Debug.Log("pontos:"+pontos);
            }

            if (collision.gameObject.tag=="bola rosa") {
                collision.gameObject.SetActive(false);
                // Debug.Log("Bola rosa DESATIVADA");
                pontos=pontos+10;
                pontosDisplay.text = "Pontos:"+pontos;

                Debug.Log("pontos:"+pontos);
            }
            
            if (collision.gameObject.tag=="bola preta") {
                collision.gameObject.SetActive(false);
                // Debug.Log("Bola preta DESATIVADA");
                pontos=pontos-15;
                pontosDisplay.text = "Pontos:"+pontos;  
                Debug.Log("pontos:"+pontos);
            }                     
    }

    public int limite = 30;
    void Update(){

        tempoJogo.text = "Tempo restante:"+(limite-(int)(Time.time));

        if(Time.time > limite && pontos < 20) {
            resultado.text = "VOCÊ PERDEU!";
            Time.timeScale = 0;
        }

        if(pontos>=20){
            resultado.text = "VOCÊ GANHOU!!!";
            Time.timeScale = 0;
        }
    }
}





