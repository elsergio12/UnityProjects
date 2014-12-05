using UnityEngine;
using System.Collections;
/*CLASE TRIGGERPUERTAOCULTA , SIRVE PARA ABRIR LA PUERTA OCULTA*/
public class TriggerPuertaOculta : MonoBehaviour {
	
	//Nuestras variables declaradas serializadas al ser privadas.
	[SerializeField]
	private GameObject Trigger4;
	private Animation AnimacionPuertaOculta;
	private bool PuertaAbierta=false;
	
	
	void Start () {
		AnimacionPuertaOculta = Trigger4.GetComponent<Animation> ();
	}
	
	void OnTriggerEnter(Collider collider)
	{
		//utilizo isplaying para que me devuelva un boolean y sepa si la animacion se esta ejecutando o no
		if (AnimacionPuertaOculta.isPlaying) {
		}
		else{
		//Condicion para asignar nuestra variable player para que al llevar la llave encima(en el inventario)se abra nuestra puerta.
			if (collider.name == "Player" && PuertaAbierta==false ) {
			AnimacionPuertaOculta.Play ("AbrirPuertaOculta");
			//Debug para lanzar un mensaje cuando se abra la puerta
			Debug.Log("Se ha abierto la puerta",gameObject);
			PuertaAbierta=true;
			}
		}
		
	}
	void OnTriggerExit(Collider collider)
	{
		//utilizo isplaying para que me devuelva un boolean y sepa si la animacion se esta ejecutando o no
		if (AnimacionPuertaOculta.isPlaying) {
		}
		else{
		//Si nuestra condicion es true (que la puerta esta abierta) con nuestro player--> La puerta se cerrara.
		if (collider.name == "Player" && PuertaAbierta==true ) {
			AnimacionPuertaOculta.Play ("CerrarPuertaOculta");
			PuertaAbierta=false;

			}
			
		}
		
	}
	
}