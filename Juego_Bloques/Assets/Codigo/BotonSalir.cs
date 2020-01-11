using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BotonSalir : MonoBehaviour {

	public bool salir;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (salir) {
				Application.Quit ();
			} 
			else {
				SceneManager.LoadScene("Portada");
				//Application.LoadLevel("Portada");
			}
		}
	}
}
