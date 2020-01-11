using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {

	public string nivelACargar;
	public float retraso;

	[ContextMenu("Activar Carga")]
	public void ActivarCarga() {
		Invoke ("CargarNivel", retraso);
	}

	void CargarNivel () {
		if (!EsUltimoNivel ()) {
			Vidas.vidas++;
		}
		SceneManager.LoadScene(nivelACargar);
	}

	public bool EsUltimoNivel () {
		return nivelACargar == "Portada";
	}
}
