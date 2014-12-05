using UnityEngine;
using System.Collections;
/*CLASE PICKUP SE UTILIZA PARA LA LLAVE*/
public class PickUp : MonoBehaviour {

	//Funcion OnTriggerEnter
	void OnTriggerEnter(Collider col)
	{	
		//Debug para lanzar un mensaje
		Debug.Log ("Ha recogido la llave  ", gameObject);
		//Condicion para recoger nuestra llave ,asignando como variable nuestro player.
		if (col.name == "Player") {
			col.gameObject.GetComponent<Inventory>().Llave = true;
			//Con el Destroy nos aseguramos de destruir el objeto para que desaparezca (pero lo tenemos en nuestro inventario).
			Destroy(this.gameObject);
		}
	}
}
