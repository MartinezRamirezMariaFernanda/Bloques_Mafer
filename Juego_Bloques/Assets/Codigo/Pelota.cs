using UnityEngine;
using System.Collections;

public class Pelota : MonoBehaviour {

	Rigidbody rig;
	public float velocidadInicial = 600f;
	bool enJuego = false;
	Transform barra;
	Vector3 posInicial;

	public ElementoInteractivo pantalla;

	// Use this for initialization
	void Start () {
		posInicial = transform.position;
	}

	public void Reset () {
		transform.position = posInicial;
		transform.SetParent (barra);
		enJuego = false;
		DetenerMovimiento();
	}

	public void DetenerMovimiento () {
		rig.isKinematic = true;
		rig.velocity = Vector3.zero;
	}

	public void Awake () {
		rig = GetComponent<Rigidbody>();
		barra = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
		if (!enJuego && (Input.GetButtonDown("Fire1") || pantalla.pulsado)) {
			enJuego = true;
			transform.SetParent (null);
			rig.isKinematic = false;
			rig.AddForce (new Vector3 (velocidadInicial, velocidadInicial, 0));
		}
	}
}
