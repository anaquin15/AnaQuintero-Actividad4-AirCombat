using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Mover hacia adelante
	 {
			this.transform.Translate (0.0f, 0.0f, 3.00f);
		}
		//movemos el avion hacia arriba

		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 4.00f, 0.0f);
		}

		// Mover hacia abajo
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -4.00f, 0.0f);
		}

		// Mover hacia el lado derecha
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (4.00f, 0.0f, 0.0f);
		}

		// Mover hacia el lado izquierda
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-4.00f, 0.0f, 0.0f);
		}
		// Si la tecla espacio fue presionada

		if (Input.GetKeyDown (KeyCode.Space)) {

			// Reconstruyo un gameObject a partir
			// de la informacion guardada en un prefab

			GameObject Missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);

			// Hago que el misil sea hijo del avion

			Missile.transform.SetParent (this.gameObject.transform);

			// Muevo el misil a unas coordenadas relativas con respecto al avion
			Missile.transform.localPosition = new Vector3(-10.0f, 21.8f, 7.0f);

			//Saco al misil del avion

			Missile.transform.SetParent (null);
		}
		
	}
}
