using UnityEngine;
using System.Collections;
/*CLASE POSITION ,SIRVE PARA TELEPORT DELANTE*/
public class Position : MonoBehaviour {

	//Declaro mis variables a utilizar en mi script
	public GameObject Transporte;
	public Vector3 TeleportPosicion;
	public GameObject Destino;

	void Start () {
		//En mi funcion start voy a decir que si el la posicion en la cual me encuentro sea igual al destino y lo transformo con el transfrom.position.
		TeleportPosicion = Destino.transform.position;
	}

	//Funcion OnTriggerEnter
	void OnTriggerEnter(Collider collider)
	{
		//Muy utilizado en los colliders, cuando entre en colision con un collider me teletransportara a la posicion que haya asignado a mi gameobject.
		Transporte.transform.position = TeleportPosicion;
	}
}
