using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletaBolasChao : MonoBehaviour {

    void OnTriggerEnter(Collider collision) {

            if (collision.gameObject.tag=="bola vermelha") {
                collision.gameObject.SetActive(false);
            }

            if (collision.gameObject.tag=="bola azul") {
                collision.gameObject.SetActive(false);
            }

            if (collision.gameObject.tag=="bola rosa") {
                collision.gameObject.SetActive(false);
            }
            
            if (collision.gameObject.tag=="bola preta") {
                collision.gameObject.SetActive(false);
            }                     
    }
}
