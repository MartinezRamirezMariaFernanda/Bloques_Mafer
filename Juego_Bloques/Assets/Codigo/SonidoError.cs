using UnityEngine;
using System.Collections;

public class SonidoError : MonoBehaviour {

	public AudioSource error;

	public void CaidaPelota () {
		error.Play();
	}
}
