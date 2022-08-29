using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaBola : MonoBehaviour {
	int i;

	public Transform SpawnPoint;


//==================================================

    public GameObject objetoNoPoller1;
    public GameObject objetoNoPoller2;
    public GameObject objetoNoPoller3;
    public GameObject objetoNoPoller4;

    public int quantidadeObjNoPool;

    public List<GameObject> instancias; // declara a lista de instancias
    int ultimoIndiceDaInstancia = 0;

    void Awake() {
		Debug.Log("entrou no awake");
        instancias = new List<GameObject>(); // instancia a lista de instancias
        int i=0;
		while (i<quantidadeObjNoPool) {

			int numAleatorio = Random.Range(0, 100);


			if(0< numAleatorio && numAleatorio <15){
				var instancia = Instantiate(objetoNoPoller1);
				instancia.SetActive(false);
				instancias.Add(instancia);
				Debug.Log("criando bola vermelha no pooler: "+i);
				i++;
				if (i>=quantidadeObjNoPool){
					break;
				}
			}

			if(10< numAleatorio && numAleatorio <60){
				var instancia = Instantiate(objetoNoPoller4);
				instancia.SetActive(false);
				instancias.Add(instancia);
				Debug.Log("criando bola preta no pooler: "+i);
				
				i++;
				if (i>=quantidadeObjNoPool){
					break;
				}
			}

			if(60< numAleatorio && numAleatorio <80){
				var instancia = Instantiate(objetoNoPoller3);
				instancia.SetActive(false);
				instancias.Add(instancia);
				Debug.Log("criando bola rosa no pooler: "+i);
				i++;
				if (i>=quantidadeObjNoPool){
					break;
				}
			}

			if(75 < numAleatorio && numAleatorio<100){
				var instancia = Instantiate(objetoNoPoller2);
				instancia.SetActive(false);
				instancias.Add(instancia);
				Debug.Log("criando bola azul no pooler: "+i);
				i++;
				if (i>=quantidadeObjNoPool){
					break;
				}
			}			

		}
    }

    public GameObject GetInstancia() {
        Debug.Log("ligou getInstancia");
        GameObject instancia = instancias[ultimoIndiceDaInstancia];
		ultimoIndiceDaInstancia++;
       // se o indice de instancia passar do tamanho do vetor de instanaicas, ele retorna para 0
        if (ultimoIndiceDaInstancia >= instancias.Count){
            ultimoIndiceDaInstancia = 0;
        }
        return instancia;
    }


//==================================================


	private void Start() {

	}
	void Update () {
		if (Time.time < 1) {
			i=1;
		}

		// Debug.Log("tempo:"+Time.time);
		// Debug.Log("tempo i :"+i);

		if (Time.time > i){
			i += 1;

			GameObject bola = GetInstancia();
			bola.transform.rotation = SpawnPoint.transform.rotation;
			float xPos1 = Random.Range(-5f, 5f);
			float zPos1 = Random.Range(-2f, 2f);
			bola.transform.position = SpawnPoint.transform.position + xPos1 * Vector3.right + zPos1 * Vector3.forward;
			bola.SetActive(true);
		}
	}
}
