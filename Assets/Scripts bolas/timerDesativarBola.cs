using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerDesativarBola : MonoBehaviour {
	public float tempoDeVida;
	void OnEnable () {
		StartCoroutine(Disabler());
	}
	private IEnumerator Disabler()
	{
		yield return new WaitForSeconds(tempoDeVida);
		gameObject.SetActive(false);
	}
}
