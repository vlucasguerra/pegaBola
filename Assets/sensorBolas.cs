using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorBolas : MonoBehaviour {

public int pontos = 0;

    void OnTriggerEnter(Collider collision) {

            if (collision.gameObject.tag=="bola vermelha") {
                collision.gameObject.SetActive(false);
                Debug.Log("Bola vermelha DESATIVADA");
                pontos++;
                Debug.Log("pontos:"+pontos);

            }

            if (collision.gameObject.tag=="bola azul") {
                collision.gameObject.SetActive(false);
                Debug.Log("Bola azul DESATIVADA");
                pontos=pontos+2;
                Debug.Log("pontos:"+pontos);
            }

            if (collision.gameObject.tag=="bola rosa") {
                collision.gameObject.SetActive(false);
                Debug.Log("Bola rosa DESATIVADA");
                pontos=pontos+10;
                Debug.Log("pontos:"+pontos);
            }
            
            if (collision.gameObject.tag=="bola preta") {
                collision.gameObject.SetActive(false);
                Debug.Log("Bola preta DESATIVADA");
                pontos=pontos-15;
                Debug.Log("pontos:"+pontos);
            }                     
    }

public int GetPontos(){
    return pontos;
}

}
