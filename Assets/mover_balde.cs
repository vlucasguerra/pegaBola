using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_balde : MonoBehaviour {

 public Vector3 pos;

    void Start() {
         pos = transform.position;
    }

public float speed = 2;
void Update() {
    Transform camTransform = Camera.main.transform;
    Vector3 posVetor = new Vector3(pos.x, pos.y, pos.z);
    Vector3 direction = (transform.position - posVetor).normalized;
    Vector3 forwardMovement = direction * Input.GetAxis("Vertical");
    Vector3 horizontalMovement = camTransform.right * Input.GetAxis("Horizontal");
    Vector3 movement = Vector3.ClampMagnitude(forwardMovement + horizontalMovement, 1);
    transform.Translate(movement * speed * Time.deltaTime, Space.World);
}




}
