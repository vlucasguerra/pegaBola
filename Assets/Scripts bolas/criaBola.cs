using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaBola : MonoBehaviour {
	int i;

	public Transform SpawnPoint;
	// public GameObject bolaDiferente;

	// private poolerDeObjetos poolerNovo;

//==================================================

    public GameObject objetoNoPoller1;
    public GameObject objetoNoPoller2;

    public int quantidadeObjNoPool;

    public List<GameObject> instancias; // declara a lista de instancias
    int ultimoIndiceDaInstancia = 0;

    void Awake() {
		Debug.Log("entrou no awake");
        instancias = new List<GameObject>(); // instancia a lista de instancias
        int i=0;
		while (i<quantidadeObjNoPool) {

			var instancia = Instantiate(objetoNoPoller1);
            instancia.SetActive(false);
            instancias.Add(instancia);
			Debug.Log("criando bola vermelha no pooler: "+i);
			i++;
			if (i>=quantidadeObjNoPool){
				break;
			}

			var instancia2 = Instantiate(objetoNoPoller2);
            instancia2.SetActive(false);
            instancias.Add(instancia2);
			Debug.Log("criando bola azul no pooler: "+i);

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

			GameObject bola1 = GetInstancia();
			bola1.transform.rotation = SpawnPoint.transform.rotation;
			float xPos1 = Random.Range(-5f, 5f);
			float zPos1 = Random.Range(-2f, 2f);
			bola1.transform.position = SpawnPoint.transform.position + xPos1 * Vector3.right + zPos1 * Vector3.forward;
			bola1.SetActive(true);
			Debug.Log("criou a bola vermelha");

			GameObject bola2 = GetInstancia();
			bola2.transform.rotation = SpawnPoint.transform.rotation;
			float xPos2 = Random.Range(-5f, 5f);
			float zPos2 = Random.Range(-2f, 2f);
			bola2.transform.position = SpawnPoint.transform.position + xPos2 * Vector3.right + zPos2 * Vector3.forward;
			bola2.SetActive(true);
		}
	}
}
