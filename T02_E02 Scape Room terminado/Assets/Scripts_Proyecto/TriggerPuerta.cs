using UnityEngine;
using System.Collections;
/*CLASE TRIGGERPUERTA , SIRVE PARA ABRIR LA PUERTA PRINCIPAL*/
public class TriggerPuerta : MonoBehaviour {

	//Nuestras variables declaradas serializadas al ser privadas.
	[SerializeField]
	private GameObject Puerta;
	private Animation AnimacionPuerta;
	private bool PuertaAbierta=false;

	
	void Start () {
			AnimacionPuerta = Puerta.GetComponent<Animation> ();
	}
	
	void OnTriggerEnter(Collider collider)
	{
		//utilizo isplaying para que me devuelva un boolean y sepa si la animacion se esta ejecutando o no
		if (AnimacionPuerta.isPlaying) {
		}
		else{
			//Condicion para asignar nuestra variable player para que al llevar la llave encima(en el inventario)se abra nuestra puerta.
			if (collider.name == "Player" && collider.gameObject.GetComponent<Inventory>().Llave && PuertaAbierta==false ) {
			AnimacionPuerta.Play ("DoorOpen1");
			//Debug para lanzar un mensaje cuando se abra la puerta
			Debug.Log("Se ha abierto la puerta",gameObject);
			PuertaAbierta=true;
			}
		}

	}
	void OnTriggerExit(Collider collider)
	{
		//utilizo isplaying para que me devuelva un boolean y sepa si la animacion se esta ejecutando o no
		if (AnimacionPuerta.isPlaying) {
		}
		else{
		//Si nuestra condicion es true (que la puerta esta abierta) con nuestro player--> La puerta se cerrara.
		if (collider.name == "Player" && PuertaAbierta==true ) {
			//Animacion para cerrar la puerta
			AnimacionPuerta.Play ("DoorClose1");
			PuertaAbierta=false;
			}

		}
		
	}

}
