using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 
public class MostraPontos : MonoBehaviour {

    public sensorBolas pegaPontos;
    public Text displayPontos;
    int pontos;
    private void Start() {
        displayPontos.text = "Pontos:"+pontos.ToString();
    }
 
    void Update() {
     pontos = pegaPontos.GetPontos();

     Debug.Log("PONTOS de dentro do mostrar pontos:"+pontos);

    }
}





