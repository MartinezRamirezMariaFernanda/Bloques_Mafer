using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vidas : MonoBehaviour {

	public static int vidas = 3;

	public Text textoVidas;

	public Pelota pelota;
	public Barra barra;

	public GameObject gameOver;
	public SiguienteNivel siguienteNivel;

	public SonidosFinPartida sonidosFinPartida;
	public SonidoError sonidoError;

	// Use this for initialization
	void Start () {
		ActualizarMarcadorVida ();
	}

	void ActualizarMarcadorVida () {
		textoVidas.text = "Vidas: " + vidas;
	}
	
	public void PerderVida() {
		if (Vidas.vidas <= 0)
			return;
		vidas--;
		ActualizarMarcadorVida ();

		if (Vidas.vidas <= 0) {
			sonidosFinPartida.GameOver();
			//Mostraremos GameOver
			gameOver.SetActive(true);
			pelota.DetenerMovimiento();
			barra.enabled = false;

			siguienteNivel.nivelACargar = "Portada";
			siguienteNivel.ActivarCarga();
		} 
		else {
			sonidoError.CaidaPelota();
			barra.Reset ();
			pelota.Reset ();
		}
	}
}
