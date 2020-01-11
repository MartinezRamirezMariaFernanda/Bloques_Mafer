using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {

	public float velocidad = 0.4f;
	private Vector3 posInicial;
	private float minPosBarra = -8f;
	private float maxPosBarra = 8f;

	public ElementoInteractivo botonIzquierda;
	public ElementoInteractivo botonDerecha;

	// Use this for initialization
	void Start () {
		posInicial = transform.position;
	}

	public void Reset () {
		transform.position = posInicial;
	}
	
	// Update is called once per frame
	void Update () {
		float direccion;

		if (botonIzquierda.pulsado) {
			direccion = -1;
		} 
		else if (botonDerecha.pulsado) {
			direccion = 1;
		} 
		else {
			direccion = Input.GetAxisRaw("Horizontal");
		}
			
		float posX = transform.position.x + (direccion * velocidad * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX, minPosBarra, maxPosBarra), transform.position.y, transform.position.z);
	}
}
