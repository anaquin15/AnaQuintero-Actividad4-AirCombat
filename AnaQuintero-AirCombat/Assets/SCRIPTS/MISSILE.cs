using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MISSILE : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Destroy (this.gameObject,10);
	}
	
	// Update is called once per frame
	void Update () {

		// mover hacia delante
		this.transform.Translate (0.0f, 10.0f, 0.0f );
		
	}

	void OnCollisionEnter(Collision collision) {

		// = Asignar
		//==Preguntar

		if (collision.collider.gameObject.tag == "Enemy") {


		// Carga el prefab de una explosion

		GameObject explosion = GameObject.Instantiate(Resources.Load ("Prefabs/Explosion") as GameObject);
			
			//Muevo la explisii=on a la posicion donde esta la nave

			explosion.transform.position = collision.collider.gameObject.transform.position;

		// Cuando el misil colision con la plataforma
		// La elimina

		Destroy (collision.collider.gameObject);

		//Destruir el misil

		Destroy (this.gameObject);
		}

		if (collision.collider.gameObject.tag == "Ally") {


			//Destruir el misil

			Destroy (this.gameObject);
	
		}
	}
}
