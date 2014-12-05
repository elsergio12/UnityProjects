using UnityEngine;
using System.Collections;
/*CLASE POSICION2 SE USA PARA TELEPORT ATRAS*/
public class Posicion2 : MonoBehaviour {

	//Declaro mis variables a utilizar en mi script
	public GameObject TransporteAtras;
	public Vector3 TeleportPosisicionAtras;
	public GameObject DestinoAtras;
		
	void Start () {
		//En mi funcion start voy a decir que si el la posicion en la cual me encuentro sea igual al destino y lo transformo con el transfrom.position.
		TeleportPosisicionAtras = DestinoAtras.transform.position;
	}
	//Funcion OnTriggerEnter
	void OnTriggerEnter(Collider collider)
	{
		//Muy utilizado en los colliders, cuando entre en colision con un collider me teletransportara a la posicion que haya asignado a mi gameobject.
		TransporteAtras.transform.position = TeleportPosisicionAtras;
	}
}
